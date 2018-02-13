using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_core_processes
    {
        public string name { get; set; }
        public int? pid { get; set; }
        public int? parent_pid { get; set; }
        public int? system_pid { get; set; }
        public int? started { get; set; }
    }
}
