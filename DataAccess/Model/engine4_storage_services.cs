using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_storage_services
    {
        public string config { get; set; }
        public int? service_id { get; set; }
        public int? servicetype_id { get; set; }
        public bool? enabled { get; set; }
        public bool? Default{get;set;}  //was originally lower case d
    }
}
