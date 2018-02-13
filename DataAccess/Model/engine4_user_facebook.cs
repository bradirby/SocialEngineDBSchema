using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_user_facebook
    {
        public string access_token { get; set; }
        public string code { get; set; }
        public int? facebook_uid { get; set; }
        public int? expires { get; set; }
        public int? user_id { get; set; }
    }
}
