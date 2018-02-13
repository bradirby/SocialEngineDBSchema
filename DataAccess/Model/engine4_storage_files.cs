using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class engine4_storage_files
    {
        public string type { get; set; }
        public string parent_type { get; set; }
        public string storage_path { get; set; }
        public string extension { get; set; }
        public string name { get; set; }
        public string mime_major { get; set; }
        public string mime_minor { get; set; }
        public string hash { get; set; }
        public DateTime? creation_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? size { get; set; }
        public int? file_id { get; set; }
        public int? parent_file_id { get; set; }
        public int? parent_id { get; set; }
        public int? user_id { get; set; }
        public int? service_id { get; set; }
    }
}
