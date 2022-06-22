using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces.Service
{
    public interface IUsuarioService
    {
        Usuario GetOneBy(int usuarioID);
        Usuario GetOneByUsuarioAcesso(string usuarioAcesso);
        List<Usuario> GetAtivos();
        bool Salvar(Usuario usuario);
        bool Remover(int usuarioID);
    }
}
