using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class LancamentoContabilItemService : ILancamentoContabilItemService
    {
        private readonly ILancamentoContabilItemRepository _lancamentoContabilItemRepository;

        public LancamentoContabilItemService(ILancamentoContabilItemRepository lancamentoContabilItemRepository)
        {
            _lancamentoContabilItemRepository = lancamentoContabilItemRepository;
        }

        public List<LancamentoContabilItem> GetAtivos(int empresaID, int lancamentoContabilID)
        {
            return _lancamentoContabilItemRepository.GetAtivos(empresaID, lancamentoContabilID);
        }

        public LancamentoContabilItem GetOneByEmpresaLancamentoItem(int empresaID, int lancamentoContabilID, int itemID)
        {
            return _lancamentoContabilItemRepository.GetOneByEmpresaLancamentoItem(empresaID, lancamentoContabilID, itemID);
        }

        public bool Remover(int empresaID, int lancamentoContabilID, int itemID, string usuario)
        {
            var ent = GetOneByEmpresaLancamentoItem(empresaID, lancamentoContabilID, itemID);
            if(ent != null)
            {
                return _lancamentoContabilItemRepository.Remover(ent, usuario);
            }
            else
            {
                return false;
            }
        }

        public bool Adicionar(LancamentoContabilItem item, string usuario)
        {
            return _lancamentoContabilItemRepository.Adicionar(item, usuario);
        }
    }
}
