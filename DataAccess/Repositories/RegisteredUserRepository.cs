using System;
using NPoco;
using SocialEngine.DataAccess.Interfaces;

namespace SocialEngine.DataAccess.Repositories
{
    public class RegisteredUserRepository : BaseRepository<RegisteredUser>, IRegisteredUserRepository
    {
        
        public RegisteredUserRepository(IDbFactory db) : base(db)
        {
        }

        //public IRegisteredUser GetById(int id)
        //{
        //    using (var db = dbFactory.GetConnection())
        //    {
        //        var usr = db.SingleOrDefaultById<RegisteredUser>(id);
        //        return usr;
        //    }
        //}

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

        //public Snapshot<IRegisteredUser> GetSnapshot(IRegisteredUser usr)
        //{
        //    using (var db = dbFactory.GetConnection())
        //    {
        //        var s = db.StartSnapshot(usr);
        //        return s;
        //    }
        //}

        //public void Insert(IRegisteredUser usr)
        //{
        //    var insertedUsr = (RegisteredUser) usr;
        //    insertedUsr.creation_date = DateTime.UtcNow;
        //    DB.Insert(insertedUsr);
        //    using (var db = dbFactory.GetConnection())
        //    {
        //        var s = db.StartSnapshot(usr);
        //        return s;
        //    }
        //}

        //public void Delete(IRegisteredUser usr)
        //{
        //    DB.Delete<RegisteredUser>(usr);
        //}

        //public void Update(IRegisteredUser usr, Snapshot<IRegisteredUser> snapshot)
        //{
        //    usr.modified_date = DateTime.UtcNow;
        //    var updatedCols = snapshot.UpdatedColumns();
        //    db.Update(usr, updatedCols);
        //}
    }
}
