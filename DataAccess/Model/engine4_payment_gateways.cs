using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_payment_gateways
    {
        public string title { get; set; }
        public string plugin { get; set; }
        public string description { get; set; }
        public int? gateway_id { get; set; }
        public bool? enabled { get; set; }
        public bool? test_mode { get; set; }
    }
}
