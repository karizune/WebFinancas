using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IGrupoRepository
    {
        Grupo GetOneByGrupoID(int grupoID);
        List<Grupo> GetAtivos();
        bool Remover(Grupo grupo, string usuario);
        bool Adicionar(Grupo grupo, string usuario);
    }
}
