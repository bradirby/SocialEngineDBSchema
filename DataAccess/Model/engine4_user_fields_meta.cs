using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEngine.DataAccess
{
    public class engine4_user_fields_meta
    {
        public string type { get; set; }
        public string label { get; set; }
        public string description { get; set; }
        public string alias { get; set; }
        public string config { get; set; }
        public string validators { get; set; }
        public string filters { get; set; }
        public string style { get; set; }
        public string error { get; set; }
        public int? field_id { get; set; }
        public bool? required { get; set; }
        public bool? display { get; set; }
        public bool? publish { get; set; }
        public bool? search { get; set; }
        public bool? show { get; set; }
    }
}
