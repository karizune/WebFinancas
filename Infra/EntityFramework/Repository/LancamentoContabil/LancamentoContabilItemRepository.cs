using Domain.Interfaces.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.EntityFramework.Repository
{
    public class LancamentoContabilItemRepository : BaseRepository<LancamentoContabilItem>, ILancamentoContabilItemRepository
    {
        public List<LancamentoContabilItem> GetAtivos(int empresaID, int lancamentoContabilID)
        {
            return GetManyBy(f => f.Status && f.EmpresaID == empresaID && f.LancamentoContabilID == lancamentoContabilID);
        }

        public LancamentoContabilItem GetOneByEmpresaLancamentoItem(int empresaID, int lancamentoContabilID, int itemID)
        {
            return GetOneBy(f => f.Status && f.EmpresaID == empresaID && f.LancamentoContabilID == lancamentoContabilID && f.LancamentoContabilItemID == itemID);
        }

        public bool Remover(LancamentoContabilItem item, string usuario)
        {
            try
            {
                var ent = GetOneByEmpresaLancamentoItem(item.EmpresaID, item.LancamentoContabilID, item.LancamentoContabilItemID);

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

        public bool Adicionar(LancamentoContabilItem item, string usuario)
        {
            try
            {
                var ent = GetOneByEmpresaLancamentoItem(item.EmpresaID, item.LancamentoContabilID, item.LancamentoContabilItemID);

                if (ent != null)
                {
                    ent.AtualizadoEm = DateTime.Now;
                    ent.Usuario = usuario;
                    ent.CodigoContabil = item.CodigoContabil;
                    ent.Valor = item.Valor;
                    ent.LancamentoTipoID = item.LancamentoTipoID;

                    Update(ent);
                }
                else
                {
                    item.AtualizadoEm = DateTime.Now;
                    item.CriadoEm = DateTime.Now;
                    item.Usuario = usuario;
                    item.Status = true;

                    Add(item);
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
