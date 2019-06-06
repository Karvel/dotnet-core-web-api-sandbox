using System.Collections.Generic;

namespace Sandbox.Models.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetUsersWithRoles();
		User GetUserWithRole(int id);
    }
}
