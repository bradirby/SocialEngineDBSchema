using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_core_tagmaps
    {
        public string resource_type { get; set; }
        public string tagger_type { get; set; }
        public string tag_type { get; set; }
        public DateTime? creation_date { get; set; }
        public string extra { get; set; }
        public int? tagmap_id { get; set; }
        public int? resource_id { get; set; }
        public int? tagger_id { get; set; }
        public int? tag_id { get; set; }
    }
}
