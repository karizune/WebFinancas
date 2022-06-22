using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces.Service
{
    public interface IContaService
    {
        Conta GetOneByGrupoConta(int grupoID, int contaID);
        List<Conta> GetAtivos(int grupoID);
        bool Salvar(Conta conta, string usuario);
        bool Remover(int grupoID, int contaID, string usuario);
    }
}
