using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_core_banners
    {
        public string name { get; set; }
        public string module { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public string Params{get;set;}
        public int? banner_id { get; set; }
        public int? photo_id { get; set; }
        public bool? custom { get; set; }
    }
}
