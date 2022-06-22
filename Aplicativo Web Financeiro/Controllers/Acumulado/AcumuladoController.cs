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
    public class AcumuladoController : Controller
    {
        public UsuarioLogado UsuarioLogado = UsuarioLogado.GetInstance();
        private readonly IAcumuladoService _acumuladoService;

        public AcumuladoController(IAcumuladoService acumuladoService)
        {
            _acumuladoService = acumuladoService;
        }

        public IActionResult Listar(int empresaID)
        {
            var lst = _acumuladoService.GetAtivos(empresaID);
            return View(lst);
        }

        public IActionResult Editar(int empresaID, int acumuladoID)
        {
            var ent = _acumuladoService.GetOneBy(empresaID, acumuladoID);
            return View(ent);
        }

        [HttpPost]
        public IActionResult Editar(Acumulado acumulado)
        {
            _acumuladoService.Adicionar(acumulado, UsuarioLogado.NomeUsuario);

            return RedirectToAction("Listar");
        }

        public IActionResult Remover(int empresaID, int acumuladoID)
        {
            _acumuladoService.Remover(empresaID, acumuladoID, UsuarioLogado.NomeUsuario);

            return RedirectToAction("Listar");
        }
    }
}
