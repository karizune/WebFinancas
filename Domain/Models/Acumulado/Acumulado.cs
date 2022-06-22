using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Acumulado
    {
        public int AcumuladoID { get; set; }
        public int EmpresaID { get; set; }
        public string CodigoContabil { get; set; }
        public string MesAno { get; set; }
        public string Usuario { get; set; }
        public bool Status { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }

        public Acumulado(int empresaID, string codigoContabil, string mesAno, string usuario)
        {
            EmpresaID = empresaID;
            CodigoContabil = codigoContabil;
            MesAno = mesAno;

            CriadoEm = AtualizadoEm = DateTime.Now;
            Usuario = usuario;
            Status = true;
        }

        public Acumulado()
        {

        }
    }
}
