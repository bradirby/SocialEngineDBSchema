using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_core_adcampaigns
    {
        public string name { get; set; }
        public string limit_ctr { get; set; }
        public string network { get; set; }
        public string level { get; set; }
        public DateTime? start_time { get; set; }
        public DateTime? end_time { get; set; }
        public int? adcampaign_id { get; set; }
        public int? limit_view { get; set; }
        public int? limit_click { get; set; }
        public int? views { get; set; }
        public int? clicks { get; set; }
        public bool? end_settings { get; set; }
        public bool? target_member { get; set; }
        public bool? status { get; set; }
    }
}
