using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_core_reports
    {
        public string category { get; set; }
        public string subject_type { get; set; }
        public DateTime? creation_date { get; set; }
        public string description { get; set; }
        public int? report_id { get; set; }
        public int? user_id { get; set; }
        public int? subject_id { get; set; }
        public bool? read { get; set; }
    }
}
