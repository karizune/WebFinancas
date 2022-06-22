using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class LancamentoTipoService : ILancamentoTipoService
    {
        private readonly ILancamentoTipoRepository _lancamentoTipoRepository;

        public LancamentoTipoService(ILancamentoTipoRepository lancamentoTipoRepository)
        {
            _lancamentoTipoRepository = lancamentoTipoRepository;
        }

        public List<LancamentoTipo> GetAtivos()
        {
            return _lancamentoTipoRepository.GetAtivos();
        }

        public LancamentoTipo GetOneByID(int lancamentoTipoID)
        {
            return _lancamentoTipoRepository.GetOneByID(lancamentoTipoID);
        }

        public bool Remover(int lancamentoTipoID, string usuario)
        {
            var ent = GetOneByID(lancamentoTipoID);

            if(ent != null)
            {
                return _lancamentoTipoRepository.Remover(ent, usuario);
            }
            else
            {
                return false;
            }
        }

        public bool Adicionar(LancamentoTipo lancamentoTipo, string usuario)
        {
            return _lancamentoTipoRepository.Adicionar(lancamentoTipo, usuario);
        }
    }
}
