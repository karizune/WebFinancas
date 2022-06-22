using Aplicativo_Web_Financeiro.Utils;
using Domain.Interfaces.Service;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Acumulado acumulado)
        {
            acumulado.EmpresaID = UsuarioLogado.EmpresaID;
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
