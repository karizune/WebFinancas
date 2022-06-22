using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IPlanoContaRepository
    {
        PlanoConta GetOneByEmpresaPlanoConta(int empresaID, int planoContaID);
        List<PlanoConta> GetAtivos(int empresaID);
        bool Remover(PlanoConta planoConta, string usuario);
        bool Adicionar(PlanoConta planoConta, string usuario);
    }
}
