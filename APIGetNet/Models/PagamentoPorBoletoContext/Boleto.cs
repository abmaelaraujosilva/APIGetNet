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

        public void StringForNull()
        {
            our_number = (our_number != "string") ? our_number : null;
            document_number = (document_number != "string") ? document_number : null;
            expiration_date = (expiration_date != "string") ? expiration_date : null;
            instructions = (instructions != "string") ? instructions : null;
            provider = (provider != "string") ? provider : null;
        }

    }
}
