using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_forum_signatures
    {
        public DateTime? creation_date { get; set; }
        public DateTime? modified_date { get; set; }
        public string body { get; set; }
        public int? signature_id { get; set; }
        public int? user_id { get; set; }
        public int? post_count { get; set; }
    }
}
