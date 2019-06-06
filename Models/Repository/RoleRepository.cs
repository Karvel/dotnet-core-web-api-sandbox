
using System;
using System.Collections.Generic;
using System.Linq;
using Sandbox.Models.Role;
using Sandbox.Models.Repository;

namespace Sandbox.Models.Repository
{
    public class RoleRepository : Repository<RoleEntity>, IRoleRepository
    {
		readonly UserContext _userContext;

        public RoleRepository(UserContext context) : base(context)
        {
            _userContext = context;
        }
    }
}
