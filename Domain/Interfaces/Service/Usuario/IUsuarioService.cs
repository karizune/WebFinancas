using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces.Service
{
    public interface IUsuarioService
    {
        Usuario GetOneByID(int usuarioID);
        Usuario GetOneByUsuarioAcesso(string usuarioAcesso);
        List<Usuario> GetAtivos();
        bool Remover(int usuarioID, string usuario);
        bool Adicionar(Usuario ent, string usuario);
    }
}
