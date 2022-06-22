using Aplicativo_Web_Financeiro.Utils;
using Domain.Interfaces.Service;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicativo_Web_Financeiro.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        private UsuarioLogado UsuarioLogado = UsuarioLogado.GetInstance();

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IActionResult Listar()
        {
            var lst = _usuarioService.GetAtivos();

            return View(lst);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Usuario usuario)
        {
            if (usuario.NomeUsuario == null || usuario.UsuarioAcesso == null || usuario.Senha == null)
            {
                return View(usuario);
            }
            _usuarioService.Adicionar(usuario, UsuarioLogado.NomeUsuario);
            return RedirectToAction("Listar");
        }

        public IActionResult Editar(int usuarioID)
        {
            var ent = _usuarioService.GetOneByID(usuarioID);

            return View(ent);
        }

        [HttpPost]
        public IActionResult Editar(Usuario usuario)
        {
            _usuarioService.Adicionar(usuario, UsuarioLogado.NomeUsuario);
            return RedirectToAction("Listar");
        }

        public IActionResult Remover(int usuarioID)
        {
            _usuarioService.Remover(usuarioID, UsuarioLogado.NomeUsuario);

            return RedirectToAction("Listar");
        }
    }
}
