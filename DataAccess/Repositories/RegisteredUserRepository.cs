using System;
using NPoco;
using SocialEngine.DataAccess.Interfaces;

namespace SocialEngine.DataAccess.Repositories
{
    public class RegisteredUserRepository : BaseRepository<RegisteredUser>, IRegisteredUserRepository
    {
        
        public RegisteredUserRepository(ISocialEngineDbFactory db) : base(db)
        {
        }

        public RegisteredUser GetByEmail(string email)
        {
            using (var db = dbFactory.GetConnection())
            {
                var sql = $"select * from engine4_users where email = @0";
                var usr = db.SingleOrDefault<RegisteredUser>(sql, email);
                return usr;
            }
        }

        public RegisteredUser GetByUsername(string username)
        {
            using (var db = dbFactory.GetConnection())
            {
                var sql = $"select * from engine4_users where username = @0";
                var usr = db.SingleOrDefault<RegisteredUser>(sql, username);
                return usr;
            }
        }

     
    }
}
