using Domain.Interfaces.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.EntityFramework.Repository
{
    public class LancamentoTipoRepository : BaseRepository<LancamentoTipo>, ILancamentoTipoRepository
    {
        public List<LancamentoTipo> GetAtivos()
        {
            return GetManyBy(f => f.Status);
        }

        public LancamentoTipo GetOneByID(int lancamentoTipoID)
        {
            return GetOneBy(f => f.Status && f.LancamentoTipoID == lancamentoTipoID);
        }

        public bool Remover(LancamentoTipo lancamentoTipo, string usuario)
        {
            try
            {
                var ent = GetOneByID(lancamentoTipo.LancamentoTipoID);

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

        public bool Adicionar(LancamentoTipo tipo, string usuario)
        {
            try
            {
                var ent = GetOneByID(tipo.LancamentoTipoID);
                if(ent != null)
                {
                    ent.AtualizadoEm = DateTime.Now;
                    ent.Usuario = usuario;
                    ent.Codigo = tipo.Codigo;
                    ent.Descricao = tipo.Descricao;

                    Update(ent);
                }
                else
                {
                    tipo.AtualizadoEm = DateTime.Now;
                    tipo.CriadoEm = DateTime.Now;
                    tipo.Status = true;
                    tipo.Usuario = usuario;

                    Add(tipo);
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
