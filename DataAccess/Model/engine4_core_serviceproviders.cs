using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_core_serviceproviders
    {
        public string title { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string Class{get;set;}  //this was originally lower case c - class
        public int? serviceprovider_id { get; set; }
        public bool? enabled { get; set; }
    }
}
