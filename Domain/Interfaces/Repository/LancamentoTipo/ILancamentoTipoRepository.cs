using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface ILancamentoTipoRepository
    {
        LancamentoTipo GetOneByID(int lancamentoTipoID);
        List<LancamentoTipo> GetAtivos();
        bool Remover(LancamentoTipo lancamentoTipo, string usuario);
        bool Adicionar(LancamentoTipo lancamentoTipo, string usuario);
    }
}
