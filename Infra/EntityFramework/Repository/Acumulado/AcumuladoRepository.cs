using Domain.Interfaces.Repository;
using Domain.Models;
using Infra.EntityFramework.Common;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Infra.EntityFramework.Repository
{
    public class AcumuladoRepository : BaseRepository<Acumulado>, IAcumuladoRepository
    {
        public List<Acumulado> GetAtivos(int empresaID)
        {
            return GetManyBy(f => f.Status && f.EmpresaID == empresaID);
        }

        public Acumulado GetOneByEmpresaAcumulado(int empresaID, int acumuladoID)
        {
            return GetOneBy(f => f.AcumuladoID == acumuladoID && f.EmpresaID == empresaID && f.Status);
        }

        public bool Adicionar(Acumulado acumulado, string usuario)
        {
            try
            {
                var ent = GetOneByEmpresaAcumulado(acumulado.EmpresaID, acumulado.AcumuladoID);

                if(acumulado != null)
                {
                    ent.AtualizadoEm = DateTime.Now;
                    ent.CodigoContabil = acumulado.CodigoContabil;
                    ent.MesAno = acumulado.MesAno;
                    ent.Usuario = usuario;

                    Update(ent);
                }
                else
                {
                    acumulado.CriadoEm = DateTime.Now;
                    acumulado.AtualizadoEm = DateTime.Now;
                    acumulado.Status = true;
                    acumulado.Usuario = usuario;

                    Add(acumulado);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Remover(Acumulado acumulado, string usuario)
        {
            try
            {
                var ent = GetOneByEmpresaAcumulado(acumulado.EmpresaID, acumulado.AcumuladoID);
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
    }
}
