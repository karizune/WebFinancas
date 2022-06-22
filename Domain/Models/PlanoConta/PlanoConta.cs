using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PlanoConta
    {
        public int PlanoContaID { get; set; }
        public int PlanoContaTipoID { get; set; }
        public int EmpresaID { get; set; }
        public string  Descricao { get; set; }

        public string Usuario { get; set; }
        public bool Status { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }

        public PlanoConta()
        {

        }

        public PlanoConta(string descricao, int planoContaTipoID, int empresaID, string usuario)
        {
            Descricao = descricao;
            EmpresaID = empresaID;
            PlanoContaTipoID = planoContaTipoID;

            Usuario = usuario;
            Status = true;
            CriadoEm = AtualizadoEm = DateTime.Now;
        }

        public Empresa Empresa { get; set; }
        public PlanoContaTipo PlanoContaTipo { get; set; }
    }
}
