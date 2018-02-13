using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_core_session
    {
        public string id { get; set; }
        public string data { get; set; }
        public int? modified { get; set; }
        public int? lifetime { get; set; }
        public int? user_id { get; set; }
    }
}
