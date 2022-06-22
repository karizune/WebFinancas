using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface ILancamentoContabilItemRepository
    {
        LancamentoContabilItem GetOneByEmpresaLancamentoItem(int empresaID, int lancamentoContabilID, int itemID);
        List<LancamentoContabilItem> GetAtivos(int empresaID, int lancamentoContabilID);
        bool Remover(LancamentoContabilItem item, string usuario);
        bool Adicionar(LancamentoContabilItem item, string usuario);
    }
}
