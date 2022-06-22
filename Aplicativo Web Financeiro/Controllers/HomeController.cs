using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Domain.Models;
using Aplicativo_Web_Financeiro.ViewModels;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;

namespace Aplicativo_Web_Financeiro.Controllers
{
    public class HomeController : Controller
    {
        public static Usuario Usuario = new Usuario();

        private IUsuarioService _usuarioService;

        public HomeController
        (
            IUsuarioService usuarioService
        )
        {
            _usuarioService = usuarioService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            var teste = _usuarioService.GetOneByUsuarioAcesso("luan");

            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            var user = _usuarioService.GetOneByUsuarioAcesso(usuario.UsuarioAcesso);

            if (user == null)
            {
                ModelState.AddModelError("UsuarioAcesso", "Usuário inexistente");
                return View(usuario);
            }

            var usuarios = _usuarioService.GetAtivos();
            user = usuarios.Find(f => f.Status && f.UsuarioAcesso == usuario.UsuarioAcesso && f.Senha == usuario.Senha);

            if (user == null)
            {
                ModelState.AddModelError("Senha", "Senha incorreta");
                return View(usuario);
            }

            return RedirectToAction("Visualizar", "Pokemon", new { id = usuario.UsuarioID });
        }

        public IActionResult Cadastro()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Cadastro(Usuario objeto)
        {

            if (objeto.NomeUsuario == null || objeto.Senha == null || objeto.Senha == null)
            {
                return View(objeto);
            }

            //db.Usuario.Add(objeto);
            //db.SaveChanges();
            return RedirectToAction("Login");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
