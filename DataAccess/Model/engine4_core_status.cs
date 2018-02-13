using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_core_status
    {
        public string resource_type { get; set; }
        public DateTime? creation_date { get; set; }
        public string body { get; set; }
        public int? status_id { get; set; }
        public int? resource_id { get; set; }
    }
}
