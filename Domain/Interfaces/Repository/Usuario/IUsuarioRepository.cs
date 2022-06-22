using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IUsuarioRepository
    {
        Usuario GetOneByID(int id);
        Usuario GetOneByUsuarioAcesso(string usuarioAcesso);
        List<Usuario> GetAtivos();
        bool Remover(Usuario ent, string usuario);
        bool Adicionar(Usuario ent, string usuario);
    }
}
