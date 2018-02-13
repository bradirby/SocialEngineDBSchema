using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_core_tasks
    {
        public string title { get; set; }
        public string module { get; set; }
        public string plugin { get; set; }
        public int? task_id { get; set; }
        public int? timeout { get; set; }
        public int? started_last { get; set; }
        public int? started_count { get; set; }
        public int? completed_last { get; set; }
        public int? completed_count { get; set; }
        public int? failure_last { get; set; }
        public int? failure_count { get; set; }
        public int? success_last { get; set; }
        public int? success_count { get; set; }
    }
}
