using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIGetNet.Models
{
    public class Billing_address
    {
        [Required]
        public string street { get; set; }
        [Required]
        public string number { get; set; }
        public string complement { get; set; }
        [Required]
        public string district { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        public string state { get; set; }
        [Required]
        public string postal_code { get; set; }

    }
}
