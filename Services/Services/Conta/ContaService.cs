using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class ContaService : IContaService
    {
        private readonly IContaRepository _contaRepository;

        public ContaService(IContaRepository contaRepository)
        {
            _contaRepository = contaRepository;
        }

        public List<Conta> GetAtivos(int grupoID)
        {
            return _contaRepository.GetAtivos(grupoID);
        }

        public Conta GetOneByGrupoConta(int grupoID, int contaID)
        {
            return _contaRepository.GetOneByContaGrupo(grupoID, contaID);
        }

        public bool Remover(int grupoID, int contaID, string usuario)
        {
            var ent = GetOneByGrupoConta(grupoID, contaID);

            if (ent != null)
            {
                return _contaRepository.Remover(ent, usuario);
            }
            else
            {
                return false;
            }
        }

        public bool Adicionar(Conta conta, string usuario)
        {
            return _contaRepository.Adicionar(conta, usuario);
        }
    }
}
