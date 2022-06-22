using Domain.Models;
using System;
using System.Collections.Generic;

namespace Domain.Interfaces.Repository
{
    public interface ILancamentoContabilRepository
    {
        LancamentoContabil GetOneByEmpresaLancamento(int empresaID, int lancamentoID);
        List<LancamentoContabil> GetAtivos(int empresaID);
        bool Adicionar(LancamentoContabil lancamento, string usuario);
        bool Remover(LancamentoContabil lancamento, string usuario);
    }
}
