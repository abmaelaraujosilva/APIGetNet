using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGetNet.Models
{
    public class PagamentoPorBoletoOutput
    {
        public PagamentoPorBoletoOutput()
        {
            StatusCode = "Não preenchido";
            Uri = "https://api-sandbox.getnet.com.br/";
        }
        public string StatusCode { get; set; }
        public string Uri { get; set; }
    }
}
