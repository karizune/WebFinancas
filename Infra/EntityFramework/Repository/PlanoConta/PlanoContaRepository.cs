using Domain.Interfaces.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.EntityFramework.Repository
{
    public class PlanoContaRepository : BaseRepository<PlanoConta>, IPlanoContaRepository
    {
        public List<PlanoConta> GetAtivos(int empresaID)
        {
            return GetManyBy(f => f.Status && f.EmpresaID == empresaID);
        }


        public PlanoConta GetOneByEmpresaPlanoConta(int empresaID, int planoContaID)
        {
            return GetOneBy(f => f.Status && f.EmpresaID == empresaID && f.PlanoContaID == planoContaID);
        }

        public bool Remover(PlanoConta planoConta, string usuario)
        {
            try
            {
                var ent = GetOneByEmpresaPlanoConta(planoConta.EmpresaID, planoConta.PlanoContaID);

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

        public bool Adicionar(PlanoConta planoConta, string usuario)
        {
            try
            {
                var ent = GetOneByEmpresaPlanoConta(planoConta.EmpresaID, planoConta.PlanoContaID);
                if(ent != null)
                {
                    ent.Usuario = usuario;
                    ent.AtualizadoEm = DateTime.Now;
                    ent.PlanoContaTipoID = planoConta.PlanoContaTipoID;
                    ent.Descricao = planoConta.Descricao;
                }
                else
                {
                    planoConta.CriadoEm = DateTime.Now;
                    planoConta.AtualizadoEm = DateTime.Now;
                    planoConta.Usuario = usuario;
                    planoConta.Status = true;
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
