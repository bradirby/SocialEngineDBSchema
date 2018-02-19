using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_invites
    {
        public string recipient { get; set; }
        public string code { get; set; }
        public DateTime? timestamp { get; set; }
        public string message { get; set; }
        public int? id { get; set; }
        public int? user_id { get; set; }
        public int? send_request { get; set; }
        public int? new_user_id { get; set; }
    }
}
