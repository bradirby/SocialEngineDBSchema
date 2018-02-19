using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Interfaces.Model;

namespace DataAccess.Interfaces
{
    public interface IUsersRepository
    {
        Iuser GetById(int id);
    }
}
