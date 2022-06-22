using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces.Service
{
    public interface ILancamentoContabilService
    {
        LancamentoContabil GetOneByEmpresaLancamento(int empresaID, int lancamentoContabilID);
        List<LancamentoContabil> GetAtivos(int empresaID);
        bool Salvar(LancamentoContabil lancamentoContabil, string usuario);
        bool Remover(int empresaID, int lancamentoContabilID, string usuario);
    }
}
