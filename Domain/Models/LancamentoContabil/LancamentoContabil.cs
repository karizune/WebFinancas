using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class LancamentoContabil
    {
        public int LancamentoContabilID { get; set; }
        public int EmpresaID { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Descricao { get; set; }
        public string Usuario { get; set; }
        public bool Status { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }

        public List<LancamentoContabilItem> Itens { get; set; }

        public LancamentoContabil()
        {
            Itens = new List<LancamentoContabilItem>();
        }

        public LancamentoContabil(int empresaID, DateTime datalancamento, string descricao, string usuario)
        {
            DataLancamento = datalancamento;
            Descricao = descricao;
            Usuario = usuario;
            Status = true;
            AtualizadoEm = CriadoEm = DateTime.Now;

            Itens = new List<LancamentoContabilItem>();
        }
    }
}
