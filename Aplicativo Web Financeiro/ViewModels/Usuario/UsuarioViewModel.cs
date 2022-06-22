using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicativo_Web_Financeiro.ViewModels
{
    public class UsuarioViewModel
    {
        const string ErroPadrao = "Obrigatório preencher o campo";

        [DisplayName("ID")]
        [Required(ErrorMessage = ErroPadrao)]
        public int UsuarioID { get; set; }

        [DisplayName("Usuario de acesso")]
        [Required(ErrorMessage = ErroPadrao)]
        public string UsuarioAcesso { get; set; }

        [DisplayName("Senha de acesso")]
        [Required(ErrorMessage = ErroPadrao)]
        public string Senha { get; set; }

        [DisplayName("Nome completo")]
        [Required(ErrorMessage = ErroPadrao)]
        public string NomeUsuario { get; set; }
    }
}
