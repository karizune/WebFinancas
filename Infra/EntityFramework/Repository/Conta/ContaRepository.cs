using Domain.Interfaces.Repository;
using Domain.Models;
using Infra.EntityFramework.Common;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Infra.EntityFramework.Repository
{
    public class ContaRepository : BaseRepository<Conta>, IContaRepository
    {
        public List<Conta> GetAtivos(int grupoID)
        {
            return GetManyBy(f => f.Status && f.GrupoID == grupoID);
        }

        public Conta GetOneByContaGrupo(int contaID, int grupoID)
        {
            return GetOneBy(f => f.ContaID == contaID && f.GrupoID == grupoID && f.Status);
        }
        public bool Adicionar(Conta conta, string usuario)
        {
            try
            {
                if(conta == null)
                {
                    return false;
                }

                var ent = GetOneByContaGrupo(conta.GrupoID, conta.ContaID);

                if (ent != null )
                {
                    ent.AtualizadoEm = DateTime.Now;
                    ent.CodigoConta = conta.CodigoConta;
                    ent.Descricao = conta.Descricao;
                    ent.GrupoID = conta.GrupoID;
                    ent.Usuario = usuario;

                    Update(ent);
                }
                else
                {
                    conta.AtualizadoEm = DateTime.Now;
                    conta.CriadoEm = DateTime.Now;
                    conta.Status = true;
                    conta.Usuario = usuario;

                    Add(conta);
                }
                
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Remover(Conta conta, string usuario)
        {
            try
            {
                if(conta != null)
                {
                    conta.AtualizadoEm = DateTime.Now;
                    conta.Status = false;
                    conta.Usuario = usuario;

                    Update(conta);
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
