using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_group_membership
    {
        public string message { get; set; }
        public string title { get; set; }
        public int? resource_id { get; set; }
        public int? user_id { get; set; }
        public bool? active { get; set; }
        public bool? resource_approved { get; set; }
        public bool? user_approved { get; set; }
    }
}
