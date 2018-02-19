using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_payment_orders
    {
        public string gateway_order_id { get; set; }
        public string gateway_transaction_id { get; set; }
        public string source_type { get; set; }
        public DateTime? creation_date { get; set; }
        public int? order_id { get; set; }
        public int? user_id { get; set; }
        public int? gateway_id { get; set; }
        public int? source_id { get; set; }
    }
}
