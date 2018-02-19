using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces.Model
{

    public interface Iuser
    {
        string password { get; set; }
        string salt { get; set; }
        string email { get; set; }
        string username { get; set; }
        string displayname { get; set; }
        string locale { get; set; }
        string language { get; set; }
        string timezone { get; set; }
        DateTime? status_date { get; set; }
        DateTime? creation_date { get; set; }
        DateTime? modified_date { get; set; }
        DateTime? lastlogin_date { get; set; }
        string status { get; set; }
        int? user_id { get; set; }
        int? photo_id { get; set; }
        int? level_id { get; set; }
        int? invites_used { get; set; }
        int? extra_invites { get; set; }
        int? update_date { get; set; }
        int? view_count { get; set; }
        int? comment_count { get; set; }
        int? like_count { get; set; }
        bool? search { get; set; }
        bool? show_profileviewers { get; set; }
        bool? enabled { get; set; }
        bool? verified { get; set; }
        bool? approved { get; set; }
    }
}
