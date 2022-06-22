using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Empresa
    {
        //props
        public int EmpresaID { get; set; }
        public string Descricao { get; set; }
        
        //logs
        public string Usuario { get; set; }
        public bool Status { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }

        public Empresa()
        {

        }

        public Empresa(string descricao, string usuario)
        {
            Usuario = usuario;
            Descricao = descricao;
            Status = true;
            AtualizadoEm = CriadoEm = DateTime.Now;
        }
    }
}
