using System.Collections.Generic;

using Sandbox.Models.Role;

namespace Sandbox.Models.Interfaces
{
	public interface IRoleService
	{
		IEnumerable<RoleEntity> GetRoles();
	}
}
