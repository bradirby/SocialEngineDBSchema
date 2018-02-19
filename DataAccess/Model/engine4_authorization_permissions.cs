using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_authorization_permissions
    {
        public string type { get; set; }
        public string name { get; set; }
        public string Params{get;set;}
        public int? level_id { get; set; }
        public bool? value { get; set; }
    }
}
