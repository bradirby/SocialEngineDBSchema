using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_core_servicetypes
    {
        public string title { get; set; }
        public string type { get; set; }
        public string Interface{get;set;}  //was originally lowercase i
        public int? servicetype_id { get; set; }
        public bool? enabled { get; set; }
    }
}
