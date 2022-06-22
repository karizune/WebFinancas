using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class PlanoContaService : IPlanoContaService
    {
        private readonly IPlanoContaRepository _planoContaRepository;

        public PlanoContaService(IPlanoContaRepository planoContaRepository)
        {
            _planoContaRepository = planoContaRepository;
        }

        public List<PlanoConta> GetAtivos(int empresaID)
        {
            return _planoContaRepository.GetAtivos(empresaID);
        }

        public PlanoConta GetOneByEmpresaPlanoConta(int empresaID, int planoContaID)
        {
            return _planoContaRepository.GetOneByEmpresaPlanoConta(empresaID, planoContaID);
        }

        public bool Remover(int empresaID, int planoContaID, string usuario)
        {
            var ent = _planoContaRepository.GetOneByEmpresaPlanoConta(empresaID, planoContaID);

            if(ent != null)
            {
                return _planoContaRepository.Adicionar(ent, usuario);
            }
            else
            {
                return false;
            }
        }

        public bool Adicionar(PlanoConta planoConta, string usuario)
        {
            return _planoContaRepository.Remover(planoConta, usuario);
        }
    }
}
