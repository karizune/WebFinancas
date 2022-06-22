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

        public bool Remover(PlanoContaTipo planoContaTipo)
        {
            try
            {
                var ent = GetOneByID(planoContaTipo.PlanoContaTipoID);

                if (ent != null)
                {
                    ent.AtualizadoEm = DateTime.Now;
                    ent.Status = false;
                    ent.Usuario = planoContaTipo.Usuario;

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
    }
}
