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

        //[HttpPost]
        //public IActionResult Criar(Empresa empresa)
        //{

        //}
    }
}
