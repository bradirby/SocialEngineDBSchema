using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_chat_events
    {
        public string type { get; set; }
        public DateTime? date { get; set; }
        public string body { get; set; }
        public int? event_id { get; set; }
        public int? user_id { get; set; }
    }
}
