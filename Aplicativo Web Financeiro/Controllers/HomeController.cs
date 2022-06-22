using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Domain.Models;
using Aplicativo_Web_Financeiro.ViewModels;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Aplicativo_Web_Financeiro.Utils;

namespace Aplicativo_Web_Financeiro.Controllers
{
    public class HomeController : Controller
    {
        private UsuarioLogado UsuarioLogado = UsuarioLogado.GetInstance();

        private IUsuarioService _usuarioService;

        public HomeController
        (
            IUsuarioService usuarioService
        )
        {
            _usuarioService = usuarioService;
        }

        public IActionResult Login()
        {
            UsuarioLogado.Reset();
            return View();
        }

        [HttpPost]
        public IActionResult Login(UsuarioViewModel usuario)
        {
            var user = _usuarioService.GetOneByUsuarioAcesso(usuario.UsuarioAcesso);

            if (user == null)
            {
                return View(usuario);
            }

            var usuarios = _usuarioService.GetAtivos();
            user = usuarios.Find(f => f.Status && f.UsuarioAcesso == usuario.UsuarioAcesso && f.Senha == usuario.Senha);

            if (user == null)
            {
                return View(usuario);
            }

            UsuarioLogado.Init(user);

            return RedirectToAction("Inicio");
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroConfirm(Usuario objeto)
        {
            if (objeto.NomeUsuario == null || objeto.UsuarioAcesso == null || objeto.Senha == null)
            {
                return View(objeto);
            }
            _usuarioService.Adicionar(objeto, UsuarioLogado.NomeUsuario);

            return RedirectToAction("Login");
        }

        public IActionResult Inicio()
        {
            if(UsuarioLogado != null && UsuarioLogado.Logado)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}
