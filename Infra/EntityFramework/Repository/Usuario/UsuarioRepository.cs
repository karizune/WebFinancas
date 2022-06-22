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

        public bool Adicionar(Usuario ent, string usuario)
        {
            try
            {
                var _ent = GetOneByID(ent.UsuarioID);
                
                if(_ent != null)
                {
                    _ent.AtualizadoEm = DateTime.Now;
                    _ent.UsuarioAcesso = ent.UsuarioAcesso;
                    _ent.NomeUsuario = ent.NomeUsuario;
                    _ent.Senha = ent.Senha;
                    _ent._usuario = usuario;
                    _ent.EmpresaID = ent.EmpresaID;

                    Update(_ent);
                }
                else
                {
                    ent.AtualizadoEm = DateTime.Now;
                    ent.CriadoEm = DateTime.Now;
                    ent.Status = true;
                    ent._usuario = usuario;

                    Add(ent);
                }

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool Remover(Usuario ent, string usuario)
        {
            try
            {
                var _ent = GetOneByID(ent.UsuarioID);

                if(_ent != null)
                {
                    _ent.AtualizadoEm = DateTime.Now;
                    _ent.Status = false;
                    _ent._usuario = usuario;

                    Update(_ent);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return true;
            }
        }
    }
}
