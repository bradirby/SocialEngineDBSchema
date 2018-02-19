using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_messages_recipients
    {
        public DateTime? inbox_updated { get; set; }
        public DateTime? outbox_updated { get; set; }
        public int? user_id { get; set; }
        public int? conversation_id { get; set; }
        public int? inbox_message_id { get; set; }
        public int? outbox_message_id { get; set; }
        public bool? inbox_read { get; set; }
        public bool? inbox_deleted { get; set; }
        public bool? outbox_deleted { get; set; }
    }
}
