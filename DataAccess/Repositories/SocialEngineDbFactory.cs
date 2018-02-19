using System.Configuration;
using NPoco;
using SocialEngine.DataAccess.Interfaces;

namespace SocialEngine.DataAccess.Repositories
{
    public class SocialEngineDbFactory : ISocialEngineDbFactory
    {
        private readonly string connectionString;
        private string ConnStrName { get; set; }

        public SocialEngineDbFactory()
        {
            ConnStrName = "SocialEngineDB";
        }

        public IDatabase GetConnection()
        {
            var connString = ConfigurationManager.ConnectionStrings[ConnStrName].ConnectionString;
            return new Database(connString, DatabaseType.MySQL);
        }
    }
}
