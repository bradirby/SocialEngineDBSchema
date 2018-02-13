using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_core_nodes
    {
        public string signature { get; set; }
        public string host { get; set; }
        public DateTime? first_seen { get; set; }
        public DateTime? last_seen { get; set; }
        public int? node_id { get; set; }
    }
}
