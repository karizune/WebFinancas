﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicativo_Web_Financeiro.Controllers
{
    public class EmpresaController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateConfirm()
        {
            return View();
        }

        public IActionResult Delete(int empresaId)
        {
            return View();
        }
    }
}
