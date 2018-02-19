using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_core_jobs
    {
        public DateTime? creation_date { get; set; }
        public DateTime? modified_date { get; set; }
        public DateTime? started_date { get; set; }
        public DateTime? completion_date { get; set; }
        public string data { get; set; }
        public string messages { get; set; }
        public int? job_id { get; set; }
        public int? jobtype_id { get; set; }
        public double? progress { get; set; }
        public bool? is_complete { get; set; }
    }
}
