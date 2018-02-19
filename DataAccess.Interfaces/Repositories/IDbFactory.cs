using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco;

namespace SocialEngine.DataAccess.Interfaces.Repositories
{
    public interface IDbFactory
    {
        IDatabase GetConnection();
    }
}
