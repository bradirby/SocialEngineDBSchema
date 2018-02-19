using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using DataAccess.Interfaces.Model;
using MySql.Data.MySqlClient;
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
            var qry = "select * from engine4_users where user_id = 1;";
            var usr = DB.Fetch<user>(qry).FirstOrDefault();
            return usr;
        }
    }
}
