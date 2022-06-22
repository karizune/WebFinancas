using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class LancamentoContabilItem
    {
        public int LancamentoContabilItemID { get; set; } // qual item é
        public int EmpresaID { get; set; } // qual empresa ele pertence
        public int LancamentoContabilID { get; set; } // qual lancamento contabil ele participa
        public int LancamentoTipoID { get; set; } // qual o tipo desse lancamento
        public string CodigoContabil { get; set; }
        public double Valor { get; set; }
        public string Usuario { get; set; }
        public bool Status { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }

        public LancamentoContabilItem()
        {

        }

        public LancamentoContabilItem
        (
            int lancamentoContabilID, 
            int empresaID,
            int lancamentoTipoID, 
            string codigocontabil, 
            float valor, 
            string usuario
        )
        {
            LancamentoContabilID = lancamentoContabilID;
            EmpresaID = empresaID;
            LancamentoTipoID = lancamentoTipoID;
            CodigoContabil = codigocontabil;
            Valor = valor;
            Usuario = usuario;
            Status = true;
            AtualizadoEm = CriadoEm = DateTime.Now;
        }
    }
}
