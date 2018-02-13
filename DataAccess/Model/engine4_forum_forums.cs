using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_forum_forums
    {
        public string title { get; set; }
        public string description { get; set; }
        public DateTime? creation_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? forum_id { get; set; }
        public int? category_id { get; set; }
        public int? file_id { get; set; }
        public int? view_count { get; set; }
        public int? topic_count { get; set; }
        public int? post_count { get; set; }
        public int? lastpost_id { get; set; }
        public int? lastposter_id { get; set; }
    }
}
