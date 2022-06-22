using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class PlanoContaTipoService : IPlanoContaTipoService
    {
        private readonly IPlanoContaTipoRepository _planoContaTipoRepository;

        public PlanoContaTipoService(IPlanoContaTipoRepository planoContaTipoRepository)
        {
            _planoContaTipoRepository = planoContaTipoRepository;
        }

        public List<PlanoContaTipo> GetAtivos()
        {
            return _planoContaTipoRepository.GetAtivos();
        }

        public PlanoContaTipo GetOneByID(int planoContaTipoID)
        {
            return _planoContaTipoRepository.GetOneByID(planoContaTipoID);
        }

        public bool Remover(int planoContaTipoID, string usuario)
        {
            try
            {
                var ent = GetOneByID(planoContaTipoID);
                if(ent != null)
                {
                    return _planoContaTipoRepository.Remover(ent, usuario);
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Adicionar(PlanoContaTipo planoContaTipo, string usuario)
        {
            return _planoContaTipoRepository.Adicionar(planoContaTipo, usuario);
        }
    }
}
