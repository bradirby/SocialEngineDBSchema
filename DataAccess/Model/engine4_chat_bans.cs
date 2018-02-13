using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_chat_bans
    {
        public string description { get; set; }
        public int? ban_id { get; set; }
        public int? user_id { get; set; }
        public int? room_id { get; set; }
        public int? expires { get; set; }
    }
}
