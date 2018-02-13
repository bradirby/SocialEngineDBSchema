using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_user_logins
    {
        public string email { get; set; }
        public string source { get; set; }
        public DateTime? timestamp { get; set; }
        public int? login_id { get; set; }
        public int? user_id { get; set; }
        public bool? active { get; set; }
    }
}
