using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces.Service
{
    public interface IGrupoService
    {
        Grupo GetOneByID(int grupoID);
        List<Grupo> GetAtivos();
        bool Remover(int grupoID, string usuario);
        bool Adicionar(Grupo grupo, string usuario);
    }
}
