using SocialEngine.DataAccess.Interfaces;

namespace SocialEngine.DataAccess.Repositories
{
    public interface IRegisteredUserRepository : IBaseRepository<RegisteredUser>
    {
        RegisteredUser GetByEmail(string email);
        RegisteredUser GetByUsername(string username);
    }
}
