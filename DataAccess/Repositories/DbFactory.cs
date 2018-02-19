using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco;
using SocialEngine.DataAccess.Interfaces;

namespace SocialEngine.DataAccess.Repositories
{
    public class DbFactory : IDbFactory
    {
        private readonly string connectionString;
        private string ConnStrName { get; set; }

        public DbFactory(string connStrName)
        {
            ConnStrName = connStrName;
        }

        public IDatabase GetConnection()
        {
            var connString = ConfigurationManager.ConnectionStrings[ConnStrName].ConnectionString;
            return new Database(connString, DatabaseType.MySQL);
        }
    }
}
