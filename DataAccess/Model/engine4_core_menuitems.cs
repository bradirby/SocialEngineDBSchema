using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_core_menuitems
    {
        public string name { get; set; }
        public string module { get; set; }
        public string label { get; set; }
        public string plugin { get; set; }
        public string menu { get; set; }
        public string submenu { get; set; }
        public string Params{get;set;}
        public int? id { get; set; }
        public bool? enabled { get; set; }
        public bool? custom { get; set; }
    }
}
