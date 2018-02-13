using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_event_events
    {
        public string title { get; set; }
        public string parent_type { get; set; }
        public string host { get; set; }
        public string location { get; set; }
        public string view_privacy { get; set; }
        public DateTime? creation_date { get; set; }
        public DateTime? modified_date { get; set; }
        public DateTime? starttime { get; set; }
        public DateTime? endtime { get; set; }
        public string description { get; set; }
        public int? event_id { get; set; }
        public int? user_id { get; set; }
        public int? parent_id { get; set; }
        public int? view_count { get; set; }
        public int? comment_count { get; set; }
        public int? like_count { get; set; }
        public int? member_count { get; set; }
        public int? photo_id { get; set; }
        public int? category_id { get; set; }
        public bool? search { get; set; }
        public bool? approval { get; set; }
        public bool? invite { get; set; }
    }
}
