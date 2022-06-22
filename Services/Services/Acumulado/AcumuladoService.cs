using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class AcumuladoService : IAcumuladoService
    {
        private readonly IAcumuladoRepository _acumuladoRepository;

        public AcumuladoService(IAcumuladoRepository acumuladoRepository)
        {
            _acumuladoRepository = acumuladoRepository;
        }

        public List<Acumulado> GetAtivos(int empresaID)
        {
            return _acumuladoRepository.GetAtivos(empresaID);
        }

        public Acumulado GetOneBy(int empresaID, int acumuladoID)
        {
            return _acumuladoRepository.GetOneByEmpresaAcumulado(empresaID, acumuladoID);
        }

        public bool Remover(int empresaID, int acumuladoID, string usuario)
        {
            var ent = _acumuladoRepository.GetOneByEmpresaAcumulado(empresaID, acumuladoID);

            if (ent != null)
            {
                return _acumuladoRepository.Remover(ent, usuario);
            }
            else
            {
                return false;
            }
        }

        public bool Adicionar(Acumulado acumulado, string usuario)
        {
            return _acumuladoRepository.Adicionar(acumulado, usuario);
        }
    }
}
