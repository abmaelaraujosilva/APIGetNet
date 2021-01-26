using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIGetNet.Models
{
    public class Order
    {
        [Required]
        public string order_id { get; set; }
        public int sales_tax { get; set; }
        public string product_type { get; set; }

    }
}
