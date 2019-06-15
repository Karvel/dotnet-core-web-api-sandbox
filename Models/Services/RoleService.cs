using System.Collections.Generic;

using Sandbox.Models.Interfaces;
using Sandbox.Models.Repository;
using Sandbox.Models.Role;

namespace Sandbox.Models.Services
{
	public class RoleService : IRoleService
	{
		readonly IUnitOfWork _unitOfWork;

		public RoleService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public IEnumerable<RoleEntity> GetRoles()
		{
			return _unitOfWork.Roles.GetAll();
		}
	}
}
