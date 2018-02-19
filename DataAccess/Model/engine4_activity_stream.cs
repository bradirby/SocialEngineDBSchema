using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_activity_stream
    {
        public string target_type { get; set; }
        public string subject_type { get; set; }
        public string object_type { get; set; }
        public string type { get; set; }
        public int? target_id { get; set; }
        public int? subject_id { get; set; }
        public int? object_id { get; set; }
        public int? action_id { get; set; }
    }
}
