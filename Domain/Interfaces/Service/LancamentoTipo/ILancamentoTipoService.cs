using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces.Service
{
    public interface ILancamentoTipoService
    {
        LancamentoTipo GetOneByID(int lancamentoTipoID);
        List<LancamentoTipo> GetAtivos();
        bool Remover(int lancamentoTipoID, string usuario);
        bool Adicionado(LancamentoTipo lancamentoTipo, string usuario);
    }
}
