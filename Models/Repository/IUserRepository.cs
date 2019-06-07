using System.Collections.Generic;

using Sandbox.Models.User;

namespace Sandbox.Models.Repository
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        IEnumerable<UserEntity> GetUsersWithRoles();
		UserEntity GetUserWithRole(int id);
    }
}
