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

        public void StringForNull()
        {
            order_id = (order_id != "string") ? order_id : null;
            //sales_tax = (sales_tax != "string") ? sales_tax : null;
            product_type = (product_type != "string") ? product_type : null;
        }

    }
}
