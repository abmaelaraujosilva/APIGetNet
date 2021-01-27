using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIGetNet.Models
{
    public class Customer
    {
        public string first_name { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string document_type { get; set; }
        [Required]
        public string document_number { get; set; }
        [Required]
        public Billing_address billing_address { get; set; }

        public void StringForNull()
        {
            first_name = (first_name != "string") ? first_name : null;
            name = (name != "string") ? name : null;
            document_type = (document_type != "string") ? document_type : null;
            document_number = (document_number != "string") ? document_number : null;
        }

    }
}
