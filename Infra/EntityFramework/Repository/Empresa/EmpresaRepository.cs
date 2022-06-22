using Domain.Interfaces.Repository;
using Domain.Models;
using Infra.EntityFramework.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.EntityFramework.Repository
{
    public class EmpresaRepository : BaseRepository<Empresa>, IEmpresaRepository
    {

        public List<Empresa> GetAtivos()
        {
            return GetManyBy(f => f.Status);
        }

        public Empresa GetOneByEmpresaID(int id)
        {
            return GetOneBy(f => f.EmpresaID == id && f.Status);
        }

        public bool Remover(Empresa empresa, string usuario)
        {
            try
            {
                var ent = GetOneByEmpresaID(empresa.EmpresaID);

                if(ent != null)
                {
                    ent.AtualizadoEm = DateTime.Now;
                    ent.Status = false;
                    ent.Usuario = empresa.Usuario;

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

        public bool Adicionar(Empresa empresa, string usuario)
        {
            try
            {
                var ent = GetOneByEmpresaID(empresa.EmpresaID);

                if(ent != null)
                {
                    ent.Descricao = empresa.Descricao;
                    ent.AtualizadoEm = empresa.AtualizadoEm;
                    ent.Usuario = usuario;
                }
                else
                {
                    empresa.CriadoEm = DateTime.Now;
                    empresa.AtualizadoEm = DateTime.Now;
                    empresa.Usuario = usuario;
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
