using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_activity_actiontypes
    {
        public string type { get; set; }
        public string module { get; set; }
        public string body { get; set; }
        public bool? enabled { get; set; }
        public bool? displayable { get; set; }
        public bool? attachable { get; set; }
        public bool? commentable { get; set; }
        public bool? shareable { get; set; }
        public bool? editable { get; set; }
        public bool? is_generated { get; set; }
    }
}
