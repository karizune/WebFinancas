using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _repository = usuarioRepository;
        }

        public List<Usuario> GetAtivos()
        {
            return _repository.GetAtivos();
        }

        public Usuario GetOneByID(int usuarioID)
        {
            return _repository.GetOneByID(usuarioID);
        }

        public Usuario GetOneByUsuarioAcesso(string usuarioAcesso)
        {
            return _repository.GetOneByUsuarioAcesso(usuarioAcesso);
        }

        public bool Remover(int usuarioID, string usuario)
        {
            try
            {
                var ent = GetOneByID(usuarioID);
                if(ent != null)
                {
                    return _repository.Remover(ent, usuario);
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

        public bool Adicionar(Usuario ent, string usuario)
        {
            return _repository.Adicionar(ent, usuario);
        }
    }
}
