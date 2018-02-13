using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_video_videos
    {
        public string title { get; set; }
        public string owner_type { get; set; }
        public string parent_type { get; set; }
        public string type { get; set; }
        public string view_privacy { get; set; }
        public DateTime? creation_date { get; set; }
        public DateTime? modified_date { get; set; }
        public string description { get; set; }
        public string code { get; set; }
        public int? video_id { get; set; }
        public int? owner_id { get; set; }
        public int? parent_id { get; set; }
        public int? view_count { get; set; }
        public int? comment_count { get; set; }
        public int? like_count { get; set; }
        public int? photo_id { get; set; }
        public int? category_id { get; set; }
        public int? file_id { get; set; }
        public int? duration { get; set; }
        public bool? search { get; set; }
        public bool? status { get; set; }
    }
}
