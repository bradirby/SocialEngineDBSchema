using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_activity_notifications
    {
        public string subject_type { get; set; }
        public string object_type { get; set; }
        public string type { get; set; }
        public DateTime? date { get; set; }
        public string Params{get;set;}
        public int? notification_id { get; set; }
        public int? user_id { get; set; }
        public int? subject_id { get; set; }
        public int? object_id { get; set; }
        public bool? read { get; set; }
        public bool? mitigated { get; set; }
    }
}
