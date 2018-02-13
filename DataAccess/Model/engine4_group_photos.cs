using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_group_photos
    {
        public string title { get; set; }
        public string description { get; set; }
        public DateTime? creation_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? photo_id { get; set; }
        public int? album_id { get; set; }
        public int? group_id { get; set; }
        public int? user_id { get; set; }
        public int? collection_id { get; set; }
        public int? file_id { get; set; }
        public int? view_count { get; set; }
        public int? comment_count { get; set; }
        public int? like_count { get; set; }
    }
}
