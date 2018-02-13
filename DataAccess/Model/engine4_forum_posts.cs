using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_forum_posts
    {
        public DateTime? creation_date { get; set; }
        public DateTime? modified_date { get; set; }
        public string body { get; set; }
        public int? post_id { get; set; }
        public int? topic_id { get; set; }
        public int? forum_id { get; set; }
        public int? user_id { get; set; }
        public int? file_id { get; set; }
        public int? edit_id { get; set; }
    }
}
