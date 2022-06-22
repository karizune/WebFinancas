using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Service
{
    public interface IPlanoContaTipoService
    {
        PlanoContaTipo GetOneByID(int planoContaTipoID);
        List<PlanoContaTipo> GetAtivos();
        bool Salvar(PlanoContaTipo planoContaTipo);
        bool Remover(int planoContaTipoID);
    }
}
