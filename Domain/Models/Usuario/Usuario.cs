using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }

        [DisplayName("Usuario de acesso")]
        public string UsuarioAcesso { get; set; }

        [DisplayName("Senha de acesso")]
        public string Senha { get; set; }

        [DisplayName("Nome do usuário")]
        public string NomeUsuario { get; set; }

        public string _usuario { get; set; }

        [DisplayName("Ativo?")]
        public bool Status { get; set; }

        [DisplayName("Criado Em")]
        public DateTime CriadoEm { get; set; }

        [DisplayName("Atualizado Em")]
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

        public Usuario GetUsuario() => this;
    }
}
