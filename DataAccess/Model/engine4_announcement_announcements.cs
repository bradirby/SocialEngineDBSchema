using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_announcement_announcements
    {
        public string title { get; set; }
        public DateTime? creation_date { get; set; }
        public DateTime? modified_date { get; set; }
        public string body { get; set; }
        public string networks { get; set; }
        public string member_levels { get; set; }
        public string profile_types { get; set; }
        public int? announcement_id { get; set; }
        public int? user_id { get; set; }
    }
}
