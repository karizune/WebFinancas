using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces.Service
{
    public interface IPlanoContaService
    {
        PlanoConta GetOneByEmpresaPlanoConta(int empresaID, int planoContaID);
        List<PlanoConta> GetAtivos(int empresaID);
        bool Adicionar(PlanoConta planoConta, string usuario);
        bool Remover(int empresaID, int planoContaID, string usuario);
    }
}
