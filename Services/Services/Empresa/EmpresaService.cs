using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;

        public EmpresaService(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public List<Empresa> GetAtivos()
        {
            return _empresaRepository.GetAtivos();
        }

        public Empresa GetOneByID(int empresaID)
        {
            return _empresaRepository.GetOneByEmpresaID(empresaID);
        }

        public bool Remover(int empresaID, string usuario)
        {
            var ent = GetOneByID(empresaID);

            if (ent != null)
            {
                return _empresaRepository.Remover(ent, usuario);
            }
            else
            {
                return false;
            }
        }

        public bool Adicionar(Empresa empresa, string usuario)
        {
            return _empresaRepository.Adicionar(empresa, usuario);
        }
    }
}
