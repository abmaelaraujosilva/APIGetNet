using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGetNet.Models
{
    public class Tokenizacao
    {
        public Tokenizacao()
        {
            StatusCode = "Não preenchido";
            Access_token = "Não preenchido, falha no método Autentificação";
            Token_Cartao = "Não preenchido";
        }
        public string StatusCode { get; set; }
        public string Access_token { get; set; }
        public string Token_Cartao { get; set; }
    }
}
