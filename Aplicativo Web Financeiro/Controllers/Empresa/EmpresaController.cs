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
    public class EmpresaController : Controller
    {
        public UsuarioLogado UsuarioLogado = UsuarioLogado.GetInstance();

        private readonly IEmpresaService _empresaService;

        public EmpresaController(IEmpresaService empresaService)
        {
            _empresaService = empresaService;
        }

        public IActionResult Listar()
        {
            var lst = _empresaService.GetAtivos();
            return View(lst);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Empresa empresa)
        {
            _empresaService.Adicionar(empresa, UsuarioLogado.NomeUsuario);
            return RedirectToAction("Listar");
        }

        public IActionResult Editar(int empresaID)
        {
            var ent = _empresaService.GetOneByID(empresaID);
            return View(ent);
        }

        [HttpPost]
        public IActionResult Editar(Empresa empresa)
        {
            _empresaService.Adicionar(empresa, UsuarioLogado.NomeUsuario);
            return RedirectToAction("Listar");
        }

        public IActionResult Remover(int empresaID)
        {
            _empresaService.Remover(empresaID, UsuarioLogado.NomeUsuario);
            return RedirectToAction("Listar");
        }
    }
}
