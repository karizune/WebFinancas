using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Repository
{
    public interface IPlanoContaTipoRepository
    {
        PlanoContaTipo GetOneByID(int planoContaTipoID);
        List<PlanoContaTipo> GetAtivos();
        bool Remover(PlanoContaTipo planoContaTipo);
    }
}
