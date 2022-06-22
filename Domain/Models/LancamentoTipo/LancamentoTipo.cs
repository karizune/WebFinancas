using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class LancamentoTipo
    {
        public int LancamentoTipoID { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Usuario { get; set; }
        public bool Status { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }

        public LancamentoTipo()
        {

        }
        public LancamentoTipo(string codigo, string descricao, string usuario)
        {
            Codigo = codigo;
            Descricao = descricao;
            Usuario = usuario;
            Status = true;
            AtualizadoEm = CriadoEm = DateTime.Now;
        }
    }
}
