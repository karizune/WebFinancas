using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Grupo
    {
        //props
        public int GrupoID { get; set; }
        public int CodigoGrupo { get; set; }
        public string Descricao { get; set; }

        //logs
        public string Usuario { get; set; }
        public bool Status { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }

        public Grupo()
        {

        }

        public Grupo(int codigoGrupo, string descricao, string usuario)
        {
            CodigoGrupo = codigoGrupo;
            Descricao = descricao;
            Usuario = usuario;
            Status = true;
            AtualizadoEm = CriadoEm = DateTime.Now;
        }
    }
}
