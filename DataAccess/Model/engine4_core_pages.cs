using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_core_pages
    {
        public string name { get; set; }
        public string displayname { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string layout { get; set; }
        public string description { get; set; }
        public string keywords { get; set; }
        public string levels { get; set; }
        public string provides { get; set; }
        public int? page_id { get; set; }
        public int? view_count { get; set; }
        public bool? custom { get; set; }
        public bool? fragment { get; set; }
        public bool? search { get; set; }
    }
}
