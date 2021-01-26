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

    }
}
