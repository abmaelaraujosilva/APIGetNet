using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGetNet.Models
{
    public class Boleto
    {
        public string our_number { get; set; }
        public string document_number { get; set; }
        public string expiration_date { get; set; }
        public string instructions { get; set; }
        public string provider { get; set; }

    }
}
