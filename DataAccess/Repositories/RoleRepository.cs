using Sandbox.Models.Role;
using Sandbox.Models.Interfaces;

namespace Sandbox.DataAccess.Repositories
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
