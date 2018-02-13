using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_activity_comments
    {
        public string poster_type { get; set; }
        public DateTime? creation_date { get; set; }
        public string body { get; set; }
        public int? comment_id { get; set; }
        public int? resource_id { get; set; }
        public int? poster_id { get; set; }
        public int? like_count { get; set; }
    }
}
