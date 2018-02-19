using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_authorization_allow
    {
        public string resource_type { get; set; }
        public string action { get; set; }
        public string role { get; set; }
        public string Params{get;set;}
        public int? resource_id { get; set; }
        public int? role_id { get; set; }
        public bool? value { get; set; }
    }
}
