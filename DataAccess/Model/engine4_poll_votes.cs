using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_poll_votes
    {
        public DateTime? creation_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? poll_id { get; set; }
        public int? user_id { get; set; }
        public int? poll_option_id { get; set; }
    }
}
