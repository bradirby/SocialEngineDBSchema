using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_poll_polls
    {
        public string title { get; set; }
        public string view_privacy { get; set; }
        public DateTime? creation_date { get; set; }
        public string description { get; set; }
        public int? poll_id { get; set; }
        public int? user_id { get; set; }
        public int? view_count { get; set; }
        public int? comment_count { get; set; }
        public int? like_count { get; set; }
        public int? vote_count { get; set; }
        public bool? is_closed { get; set; }
        public bool? search { get; set; }
        public bool? closed { get; set; }
    }
}
