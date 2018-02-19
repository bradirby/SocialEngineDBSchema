using System;
using NPoco;

namespace SocialEngine.DataAccess
{

    [TableName("engine4_users")]
    [PrimaryKey("user_id")]
    public class RegisteredUser 
    {
        public string password { get; set; }
        public string salt { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string displayname { get; set; }
        public string locale { get; set; }
        public string language { get; set; }
        public string timezone { get; set; }
        public DateTime? status_date { get; set; }
        public DateTime? creation_date { get; set; }
        public DateTime? modified_date { get; set; }
        public DateTime? lastlogin_date { get; set; }
        public string status { get; set; }

        /// <summary>
        /// Primary key for the table, this is read only.  The user_id is an autoincrement field in the DB so 
        /// adding a value here for inserting is ignored.  this is nullable in the DB
        /// </summary>
        public int user_id { get; set; } 
        public int? photo_id { get; set; }
        public int? level_id { get; set; }
        public int? invites_used { get; set; }
        public int? extra_invites { get; set; }
        public int? update_date { get; set; }
        public int? view_count { get; set; }
        public int? comment_count { get; set; }
        public int? like_count { get; set; }
        public bool? search { get; set; }
        public bool? show_profileviewers { get; set; }
        public bool? enabled { get; set; }
        public bool? verified { get; set; }
        public bool? approved { get; set; }

        public RegisteredUser()
        {
            creation_date = DateTime.UtcNow;
            modified_date = creation_date;
        }
    }
}
