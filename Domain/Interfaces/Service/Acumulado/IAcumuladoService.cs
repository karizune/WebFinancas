using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces.Service
{
    public interface IAcumuladoService
    {
        Acumulado GetOneBy(int empresaID, int acumuladoID);
        List<Acumulado> GetAtivos(int empresaID);
        bool Adicionar(Acumulado acumulado, string usuario);
        bool Remover(int empresaID, int acumuladoID, string usuario);
    }
}
