using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_core_mail
    {
        public string body { get; set; }
        public DateTime? creation_time { get; set; }
        public int? mail_id { get; set; }
        public int? recipient_count { get; set; }
        public int? recipient_total { get; set; }
    }
}
