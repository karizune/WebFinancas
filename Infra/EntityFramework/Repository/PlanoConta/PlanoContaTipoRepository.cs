using Domain.Interfaces.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.EntityFramework.Repository
{
    public class PlanoContaTipoRepository : BaseRepository<PlanoContaTipo>, IPlanoContaTipoRepository
    {
        public List<PlanoContaTipo> GetAtivos()
        {
            return GetManyBy(f => f.Status);
        }

        public PlanoContaTipo GetOneByID(int planoContaTipoID)
        {
            return GetOneBy(f => f.PlanoContaTipoID == planoContaTipoID);
        }

        public bool Remover(PlanoContaTipo planoContaTipo, string usuario)
        {
            try
            {
                var ent = GetOneByID(planoContaTipo.PlanoContaTipoID);

                if (ent != null)
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

        public bool Adicionar(PlanoContaTipo planoContaTipo, string usuario)
        {
            try
            {
                var ent = GetOneByID(planoContaTipo.PlanoContaTipoID);
                if(ent != null)
                {
                    ent.AtualizadoEm = DateTime.Now;
                    ent.Usuario = usuario;
                    ent.Descricao = planoContaTipo.Descricao;
                    ent.Codigo = planoContaTipo.Codigo;

                    Update(ent);
                }
                else
                {
                    planoContaTipo.CriadoEm = DateTime.Now;
                    planoContaTipo.AtualizadoEm = DateTime.Now;
                    planoContaTipo.Status = true;
                    planoContaTipo.Usuario = usuario;

                    Add(planoContaTipo);
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
