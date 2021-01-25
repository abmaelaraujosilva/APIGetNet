using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGetNet.Models
{
    public class Autenticacao
    {
        public Autenticacao()
        {
            StatusCode = "Não preenchido";
            Token_Acesso = "Não preenchido";
        }
        public string StatusCode { get; set; }
        public string Token_Acesso { get; set; }
    }
}
