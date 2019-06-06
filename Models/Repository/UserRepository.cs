
using System;
using System.Collections.Generic;
using System.Linq;

using Sandbox.Models.Repository;
using Sandbox.Models.User;

namespace Sandbox.Models.Repository
{
    public class UserRepository : Repository<UserEntity>, IUserRepository
    {
		readonly UserContext _userContext;

        public UserRepository(UserContext context) : base(context)
        {
            _userContext = context;
        }

        public IEnumerable<UserEntity> GetUsersWithRoles()
        {
            return _userContext.Users.ToList();
        }

		public UserEntity GetUserWithRole(int id)
        {
            return _userContext.Users.FirstOrDefault(user => user.UserId == id);
        }
    }
}
