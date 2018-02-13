using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_chat_messages
    {
        public DateTime? date { get; set; }
        public string body { get; set; }
        public int? message_id { get; set; }
        public int? room_id { get; set; }
        public int? user_id { get; set; }
        public bool? system { get; set; }
    }
}
