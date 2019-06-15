using System.Collections.Generic;

using Sandbox.Models.Role;

namespace Sandbox.Models.Interfaces
{
	public interface IRoleManager
	{
		IEnumerable<RoleEntity> GetRoles();
	}
}
