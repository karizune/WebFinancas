using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class LancamentoContabilService : ILancamentoContabilService
    {
        private readonly ILancamentoContabilRepository _lancamentoContabilRepository;

        public List<LancamentoContabil> GetAtivos(int empresaID)
        {
            return _lancamentoContabilRepository.GetAtivos(empresaID);
        }

        public LancamentoContabil GetOneByEmpresaLancamento(int empresaID, int lancamentoID)
        {
            return _lancamentoContabilRepository.GetOneByEmpresaLancamento(empresaID, lancamentoID);
        }

        public bool Remover(int empresaID, int lancamentoID, string usuario)
        {
            var ent = GetOneByEmpresaLancamento(empresaID, lancamentoID);
            
            if(ent != null)
            {
                return _lancamentoContabilRepository.Remover(ent, usuario);
            }
            else
            {
                return false;
            }
        }

        public bool Salvar(LancamentoContabil lancamento, string usuario)
        {
            return _lancamentoContabilRepository.Adicionar(lancamento, usuario);
        }
    }
}
