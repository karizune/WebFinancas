using Domain.Interfaces.Repository;
using Domain.Models;
using Infra.EntityFramework.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.EntityFramework.Repository
{
    public class GrupoRepository : BaseRepository<Grupo>, IGrupoRepository
    {
        public List<Grupo> GetAtivos()
        {
            return GetManyBy(f => f.Status);
        }

        public Grupo GetOneByGrupoID(int id)
        {
            return GetOneBy(f => f.GrupoID == id);
        }

        public bool Remover(Grupo grupo, string usuario)
        {
            try
            {
                var ent = GetOneByGrupoID(grupo.GrupoID);
                if(ent != null)
                {
                    ent.AtualizadoEm = DateTime.Now;
                    ent.Status = false;
                    ent.Usuario = usuario;

                    Update(ent);
                    return true;
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

        public bool Adicionar(Grupo grupo, string usuario)
        {
            try
            {
                var ent = GetOneByGrupoID(grupo.GrupoID);

                if(ent != null)
                {
                    ent.AtualizadoEm = DateTime.Now;
                    ent.Descricao = grupo.Descricao;
                    ent.CodigoGrupo = grupo.CodigoGrupo;
                    ent.Usuario = usuario;

                    Update(ent);
                }
                else
                {
                    grupo.AtualizadoEm = DateTime.Now;
                    grupo.CriadoEm = DateTime.Now;
                    grupo.Status = true;
                    grupo.Usuario = usuario;

                    Add(grupo);
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
