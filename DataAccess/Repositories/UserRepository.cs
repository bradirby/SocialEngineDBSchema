using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using DataAccess.Interfaces.Model;
using NPoco;

namespace DataAccess.Repositories
{
    public class UserRepository : IUsersRepository
    {
        private IDatabase DB { get; set; }

        public UserRepository(IDatabase db)
        {
            DB = db;
        }

        public Iuser GetById(int id)
        {
            var usr = DB.SingleById<user>(id);
            return usr;
        }

        public Snapshot<Iuser> GetSnapshot(Iuser usr)
        {
            var s = DB.StartSnapshot(usr);
            return s;
        }

        public void Update(Iuser usr)
        {
            //DB.Update<user>()
        }
        public void Update(Iuser usr, Snapshot<Iuser> snapshot)
        {
            var updatedCols = snapshot.UpdatedColumns();
            DB.Update(usr, updatedCols);
        }
    }
}
