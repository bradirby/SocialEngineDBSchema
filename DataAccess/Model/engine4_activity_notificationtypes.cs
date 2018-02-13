using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_activity_notificationtypes
    {
        public string type { get; set; }
        public string module { get; set; }
        public string handler { get; set; }
        public string body { get; set; }
        public bool? is_request { get; set; }
        public bool? Default{get;set;}
    }
}
