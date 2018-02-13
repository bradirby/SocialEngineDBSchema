using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_event_topics
    {
        public string title { get; set; }
        public DateTime? creation_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? topic_id { get; set; }
        public int? event_id { get; set; }
        public int? user_id { get; set; }
        public int? view_count { get; set; }
        public int? post_count { get; set; }
        public int? lastpost_id { get; set; }
        public int? lastposter_id { get; set; }
        public bool? sticky { get; set; }
        public bool? closed { get; set; }
    }
}
