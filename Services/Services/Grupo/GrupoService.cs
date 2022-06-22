using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class GrupoService : IGrupoService
    {
        private readonly IGrupoRepository _grupoRepository;

        public GrupoService(IGrupoRepository grupoRepository)
        {
            _grupoRepository = grupoRepository;
        }

        public List<Grupo> GetAtivos()
        {
            return _grupoRepository.GetAtivos();
        }

        public Grupo GetOneByID(int grupoID)
        {
            return _grupoRepository.GetOneByGrupoID(grupoID);
        }

        public bool Remover(int grupoID, string usuario)
        {
            var ent = GetOneByID(grupoID);

            if (ent != null)
            {
                return _grupoRepository.Remover(ent, usuario);
            }
            else
            {
                return false;
            }
        }

        public bool Adicionar(Grupo grupo, string usuario)
        {
            return _grupoRepository.Adicionar(grupo, usuario);
        }
    }
}
