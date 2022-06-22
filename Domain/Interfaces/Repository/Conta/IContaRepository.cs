using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IContaRepository
    {
        Conta GetOneByContaGrupo(int contaID, int grupoID);
        List<Conta> GetAtivos(int grupoID);
        bool Remover(Conta conta, string usuario);
        bool Adicionar(Conta conta, string usuario);
    }
}
