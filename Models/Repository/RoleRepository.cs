
using System;
using System.Collections.Generic;
using System.Linq;
using Sandbox.Models;
using Sandbox.Models.Repository;

namespace Sandbox.Models.Repository
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
		readonly UserContext _userContext;

        public RoleRepository(UserContext context) : base(context)
        {
            _userContext = context;
        }
    }
}
