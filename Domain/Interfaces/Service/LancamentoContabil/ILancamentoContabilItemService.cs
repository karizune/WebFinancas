using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces.Service
{
    public interface ILancamentoContabilItemService
    {
        LancamentoContabilItem GetOneByEmpresaLancamentoItem(int empresaID, int lancamentoContabilID, int itemID);
        List<LancamentoContabilItem> GetAtivos(int empresaID, int lancamentoContabilID);
        bool Remover(int empresaID, int lancamentoContabilID, int itemID, string usuario);
        bool Adicionar(LancamentoContabilItem item, string usuario);
    }
}
