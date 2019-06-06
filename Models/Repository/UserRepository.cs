
using System;
using System.Collections.Generic;
using System.Linq;
using Sandbox.Models;
using Sandbox.Models.Repository;

namespace Sandbox.Models.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
		readonly UserContext _userContext;

        public UserRepository(UserContext context) : base(context)
        {
            _userContext = context;
        }

        public IEnumerable<User> GetUsersWithRoles()
        {
            return _userContext.Users.ToList();
        }

		public User GetUserWithRole(int id)
        {
            return _userContext.Users.FirstOrDefault(user => user.UserId == id);
        }
    }
}
