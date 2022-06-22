using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IEmpresaRepository
    {
        Empresa GetOneByEmpresaID(int empresaID);
        List<Empresa> GetAtivos();
        bool Remover(Empresa empresa, string usuario);
        bool Adicionar(Empresa empresa, string usuario);
    }
}
