using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_core_adphotos
    {
        public string title { get; set; }
        public string description { get; set; }
        public DateTime? creation_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? adphoto_id { get; set; }
        public int? ad_id { get; set; }
        public int? file_id { get; set; }
    }
}
