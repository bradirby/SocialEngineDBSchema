using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_forum_categories
    {
        public string title { get; set; }
        public string description { get; set; }
        public DateTime? creation_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? category_id { get; set; }
        public int? forum_count { get; set; }
    }
}
