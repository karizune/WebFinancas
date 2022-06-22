using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Conta
    {
        //pk
        public int ContaID { get; set; }

        //fk
        public int GrupoID { get; set; }

        // props
        public int CodigoConta { get; set; }
        public string Descricao { get; set; }

        // logs
        public string Usuario { get; set; }
        public bool Status { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }

        // 1-1
        public Grupo Grupo{ get; set; }


        public Conta(int grupoID, int codigoConta, string descricao, string usuario)
        {
            CriadoEm = AtualizadoEm = DateTime.Now;
            Usuario = usuario;
            Status = true;
            GrupoID = grupoID;
            Descricao = descricao;
            CodigoConta = codigoConta;
        }

        public Conta()
        {

        }
    }
}
