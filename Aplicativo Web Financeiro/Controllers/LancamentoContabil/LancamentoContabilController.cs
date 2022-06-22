using Aplicativo_Web_Financeiro.Utils;
using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicativo_Web_Financeiro.Controllers
{
    public class LancamentoContabilController : Controller
    {
        public UsuarioLogado UsuarioLogado = UsuarioLogado.GetInstance();

        private readonly ILancamentoContabilService _lancamentoContabilService;

        public LancamentoContabilController(ILancamentoContabilService lancamentoContabilService)
        {
            _lancamentoContabilService = lancamentoContabilService;
        }

        public IActionResult Listar(int empresaID)
        {
            var lst = _lancamentoContabilService.GetAtivos(empresaID);
            return View(lst);
        }
    }
}
