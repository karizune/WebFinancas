using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicativo_Web_Financeiro.Controllers
{
    public class LancamentoContabilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
