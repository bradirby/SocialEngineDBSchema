using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_core_jobtypes
    {
        public string title { get; set; }
        public string type { get; set; }
        public string module { get; set; }
        public string plugin { get; set; }
        public string form { get; set; }
        public int? jobtype_id { get; set; }
        public bool? enabled { get; set; }
        public bool? multi { get; set; }
    }
}
