using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_messages_messages
    {
        public string title { get; set; }
        public string attachment_type { get; set; }
        public DateTime? date { get; set; }
        public string body { get; set; }
        public int? message_id { get; set; }
        public int? conversation_id { get; set; }
        public int? user_id { get; set; }
        public int? attachment_id { get; set; }
    }
}
