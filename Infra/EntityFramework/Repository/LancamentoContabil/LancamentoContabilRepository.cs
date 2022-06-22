using Domain.Interfaces.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.EntityFramework.Repository
{
    public class LancamentoContabilRepository : BaseRepository<LancamentoContabil>, ILancamentoContabilRepository
    {
        public List<LancamentoContabil> GetAtivos(int empresaID)
        {
            return GetManyBy(f => f.Status && f.EmpresaID == empresaID);
        }

        public LancamentoContabil GetOneByEmpresaLancamento(int empresaID, int lancamentoID)
        {
            return GetOneBy(f => f.Status && f.EmpresaID == empresaID && f.LancamentoContabilID == lancamentoID);
        }

        public bool Remover(LancamentoContabil lancamento, string usuario)
        {
            try
            {
                var ent = GetOneByEmpresaLancamento(lancamento.EmpresaID, lancamento.LancamentoContabilID);

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

        public bool Adicionar(LancamentoContabil lancamento, string usuario)
        {
            try
            {
                var ent = GetOneByEmpresaLancamento(lancamento.EmpresaID, lancamento.LancamentoContabilID);

                if (ent != null)
                {
                    ent.AtualizadoEm = DateTime.Now;
                    ent.DataLancamento = lancamento.DataLancamento;
                    ent.Descricao = lancamento.Descricao;
                    ent.Usuario = usuario;

                    Update(ent);
                }
                else
                {
                    lancamento.AtualizadoEm = DateTime.Now;
                    lancamento.CriadoEm = DateTime.Now;
                    lancamento.Status = true;
                    lancamento.Usuario = usuario;

                    Add(lancamento);
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