using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_blog_blogs
    {
        public string title { get; set; }
        public string owner_type { get; set; }
        public string view_privacy { get; set; }
        public string body { get; set; }
        public DateTime? creation_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? blog_id { get; set; }
        public int? owner_id { get; set; }
        public int? category_id { get; set; }
        public int? photo_id { get; set; }
        public int? view_count { get; set; }
        public int? comment_count { get; set; }
        public int? like_count { get; set; }
        public bool? search { get; set; }
        public bool? draft { get; set; }
    }
}
