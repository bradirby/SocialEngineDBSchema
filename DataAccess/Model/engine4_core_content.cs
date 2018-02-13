using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_core_content
    {
        public string type { get; set; }
        public string name { get; set; }
        public string Params{get;set;}
        public string attribs { get; set; }
        public int? content_id { get; set; }
        public int? page_id { get; set; }
        public int? parent_content_id { get; set; }
        public int? order { get; set; }
    }
}
