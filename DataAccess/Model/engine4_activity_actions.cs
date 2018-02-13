﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_activity_actions
    {
        public string type { get; set; }
        public string subject_type { get; set; }
        public string object_type { get; set; }
        public DateTime? date { get; set; }
        public DateTime? modified_date { get; set; }
        public string body { get; set; }
        public string Params{get;set;}

        public int? action_id { get; set; }
        public int? subject_id { get; set; }
        public int? object_id { get; set; }
    }
}
