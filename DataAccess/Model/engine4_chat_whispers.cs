using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_chat_whispers
    {
        public DateTime? date { get; set; }
        public string body { get; set; }
        public int? whisper_id { get; set; }
        public int? recipient_id { get; set; }
        public int? sender_id { get; set; }
        public bool? recipient_deleted { get; set; }
        public bool? sender_deleted { get; set; }
    }
}
