using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string UsuarioAcesso { get; set; }
        public string Senha { get; set; }
        public string NomeUsuario { get; set; }

        public string _usuario { get; set; }
        public bool Status { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }

        public Usuario()
        {

        }

        public Usuario(string usuarioAcesso, string senha, string nomeUsuario, string usuario)
        {
            UsuarioAcesso = usuarioAcesso;
            Senha = senha;
            NomeUsuario = nomeUsuario;
            _usuario = usuario;
            Status = true;
            CriadoEm = AtualizadoEm = DateTime.Now;
        }
    }
}
