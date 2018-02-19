using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_payment_products
    {
        public string extension_type { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int? sku { get; set; }
        public int? product_id { get; set; }
        public int? extension_id { get; set; }
        public double? price { get; set; }
    }
}
