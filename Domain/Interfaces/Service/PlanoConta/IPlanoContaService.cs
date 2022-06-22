using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces.Service
{
    public interface IPlanoContaService
    {
        PlanoConta GetOneByEmpresaPlanoConta(int empresaID, int planoContaID);
        List<PlanoConta> GetAtivos();
        bool Salvar(PlanoConta usuario);
        bool Remover(int empresaID, int planoContaID);
    }
}
