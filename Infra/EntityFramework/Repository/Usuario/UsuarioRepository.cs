using Domain.Interfaces.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.EntityFramework.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public List<Usuario> GetAtivos()
        {
            return GetManyBy(f => f.Status);
        }

        public Usuario GetOneByID(int id)
        {
            return GetOneBy(f => f.Status && f.UsuarioID == id);
        }

        public Usuario GetOneByUsuarioAcesso(string usuarioAcesso)
        {
            return GetOneBy(f => f.UsuarioAcesso == usuarioAcesso);
        }

        public bool Remover(Usuario usuario)
        {
            try
            {
                var ent = GetOneByID(usuario.UsuarioID);
                
                if(ent != null)
                {
                    ent.AtualizadoEm = DateTime.Now;
                    ent.UsuarioAcesso = usuario.UsuarioAcesso;
                    ent.NomeUsuario = usuario.NomeUsuario;
                    ent.Senha = usuario.Senha;
                    ent._usuario = usuario._usuario;

                    Update(ent);
                }
                else
                {
                    usuario.AtualizadoEm = DateTime.Now;
                    usuario.CriadoEm = DateTime.Now;

                    Add(usuario);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
