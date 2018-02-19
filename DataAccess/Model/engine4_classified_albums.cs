using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_classified_albums
    {
        public string title { get; set; }
        public DateTime? creation_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? album_id { get; set; }
        public int? classified_id { get; set; }
        public int? photo_id { get; set; }
        public int? view_count { get; set; }
        public int? comment_count { get; set; }
        public int? like_count { get; set; }
        public int? collectible_count { get; set; }
        public bool? search { get; set; }
    }
}
