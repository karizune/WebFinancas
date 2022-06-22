using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PlanoContaTipo
    {
        public int PlanoContaTipoID { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Usuario { get; set; }
        public bool Status { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }


        public PlanoContaTipo()
        {

        }

        public PlanoContaTipo(string codigo, string descricao, string usuario)
        {
            Codigo = codigo;
            Descricao = descricao;
            Usuario = usuario;
            Status = true;
            AtualizadoEm = CriadoEm = DateTime.Now;
        }
    }
}
