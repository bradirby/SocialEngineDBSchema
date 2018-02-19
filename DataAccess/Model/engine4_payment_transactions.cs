using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_payment_transactions
    {
        public string currency { get; set; }
        public string type { get; set; }
        public string state { get; set; }
        public string gateway_transaction_id { get; set; }
        public string gateway_parent_transaction_id { get; set; }
        public string gateway_order_id { get; set; }
        public DateTime? timestamp { get; set; }
        public int? transaction_id { get; set; }
        public int? user_id { get; set; }
        public int? gateway_id { get; set; }
        public int? order_id { get; set; }
        public double? amount { get; set; }
    }
}
