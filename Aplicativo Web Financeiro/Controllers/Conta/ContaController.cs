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
    public class ContaController : Controller
    {
        public UsuarioLogado UsuarioLogado = UsuarioLogado.GetInstance();
        private readonly IContaService _contaService;

        public ContaController(IContaService contaService)
        {
            _contaService = contaService;
        }

        public IActionResult Listar(int grupoID)
        {
            var lst = _contaService.GetAtivos(grupoID);
            return View(lst);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Conta conta)
        {
            _contaService.Adicionar(conta, UsuarioLogado.NomeUsuario);
            return RedirectToAction("Listar");
        }

        public IActionResult Editar(int grupoID, int contaID)
        {
            var ent = _contaService.GetOneByGrupoConta(grupoID, contaID);
            return View(ent);
        }

        [HttpPost]
        public IActionResult Editar(Conta conta)
        {
            _contaService.Adicionar(conta, UsuarioLogado.NomeUsuario);
            return RedirectToAction("Listar");
        }

        public IActionResult Remover(int grupoID, int contaID)
        {
            _contaService.Remover(grupoID, contaID, UsuarioLogado.NomeUsuario);
            return RedirectToAction("Listar");
        }
    }
}
