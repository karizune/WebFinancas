using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicativo_Web_Financeiro.Utils
{
    public sealed class UsuarioLogado
    {
        public static UsuarioLogado _instance;

        public string NomeUsuario { get; set; }
        public bool Logado { get; set; }

        private UsuarioLogado()
        {
            NomeUsuario = "sistema"; //default
            Logado = false;
        }

        public static UsuarioLogado GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UsuarioLogado();
            }
            return _instance;
        }

        public static void Init(Usuario usuario)
        {
            _instance.NomeUsuario = usuario.NomeUsuario;
            _instance.Logado = true;
        }

        public static void Reset()
        {
            _instance = new UsuarioLogado();
        }
    }
}
