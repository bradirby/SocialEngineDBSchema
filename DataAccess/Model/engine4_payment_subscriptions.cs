using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_payment_subscriptions
    {
        public string gateway_profile_id { get; set; }
        public DateTime? creation_date { get; set; }
        public DateTime? modified_date { get; set; }
        public DateTime? payment_date { get; set; }
        public DateTime? expiration_date { get; set; }
        public string notes { get; set; }
        public int? subscription_id { get; set; }
        public int? user_id { get; set; }
        public int? package_id { get; set; }
        public int? gateway_id { get; set; }
        public bool? active { get; set; }
    }
}
