using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_messages_conversations
    {
        public string title { get; set; }
        public string resource_type { get; set; }
        public DateTime? modified { get; set; }
        public int? conversation_id { get; set; }
        public int? user_id { get; set; }
        public int? recipients { get; set; }
        public int? resource_id { get; set; }
        public bool? locked { get; set; }
    }
}
