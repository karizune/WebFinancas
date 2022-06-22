using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces.Repository
{
    public interface IAcumuladoRepository
    {
        Acumulado GetOneByEmpresaAcumulado(int empresaID, int acumuladoID);
        List<Acumulado> GetAtivos(int empresaID);
        bool Remover(Acumulado acumulado, string usuario);
        bool Adicionar(Acumulado acumulado);
    }
}
