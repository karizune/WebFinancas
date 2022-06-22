using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces.Service
{
    public interface IEmpresaService
    {
        Empresa GetOneByID(int empresaID);
        List<Empresa> GetAtivos();
        bool Remover(int empresaID, string usuario);
        bool Salvar(Empresa empresa, string usuario);
    }
}
