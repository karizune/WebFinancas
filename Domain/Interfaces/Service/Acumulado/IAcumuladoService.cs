using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces.Service
{
    public interface IAcumuladoService
    {
        Acumulado GetOneBy(int empresaID, int acumuladoID);
        List<Acumulado> GetAtivos(int empresaID);
        bool Salvar(Acumulado acumulado);
        bool Remover(int empresaID, int acumuladoID, string usuario);
    }
}
