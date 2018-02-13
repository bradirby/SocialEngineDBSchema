using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_core_links
    {
        public string uri { get; set; }
        public string title { get; set; }
        public string parent_type { get; set; }
        public string owner_type { get; set; }
        public DateTime? creation_date { get; set; }
        public string description { get; set; }
        public string Params{get;set;}
        public int? link_id { get; set; }
        public int? photo_id { get; set; }
        public int? parent_id { get; set; }
        public int? owner_id { get; set; }
        public bool? search { get; set; }
    }
}
