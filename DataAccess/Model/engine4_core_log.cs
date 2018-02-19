using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_core_log
    {
        public string domain { get; set; }
        public string plugin { get; set; }
        public string priorityName { get; set; }
        public string message { get; set; }
        public DateTime? timestamp { get; set; }
        public int? message_id { get; set; }
        public int? user_id { get; set; }
    }
}
