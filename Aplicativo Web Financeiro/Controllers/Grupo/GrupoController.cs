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
    public class GrupoController : Controller
    {
        public UsuarioLogado UsuarioLogado = UsuarioLogado.GetInstance();
        private readonly IGrupoService _grupoService;

        public GrupoController(IGrupoService grupoService)
        {
            _grupoService = grupoService;
        }

        public IActionResult Listar()
        {
            var lst = _grupoService.GetAtivos();
            return View(lst);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Grupo grupo)
        {
            _grupoService.Adicionar(grupo, UsuarioLogado.NomeUsuario);
            return RedirectToAction("Listar");
        }

        public IActionResult Remover(int grupoID)
        {
            _grupoService.Remover(grupoID, UsuarioLogado.NomeUsuario);
            return RedirectToAction("Listar");
        }
    }
}
