using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_payment_packages
    {
        public string title { get; set; }
        public string description { get; set; }
        public int? package_id { get; set; }
        public int? level_id { get; set; }
        public int? downgrade_level_id { get; set; }
        public int? recurrence { get; set; }
        public int? duration { get; set; }
        public int? trial_duration { get; set; }
        public double? price { get; set; }
        public bool? enabled { get; set; }
        public bool? signup { get; set; }
        public bool? after_signup { get; set; }
        public bool? Default{get;set;}  //was originally lowercase d
    }
}
