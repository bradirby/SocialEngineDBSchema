using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_forum_topicwatches
    {
        public int? resource_id { get; set; }
        public int? topic_id { get; set; }
        public int? user_id { get; set; }
        public bool? watch { get; set; }
    }
}
