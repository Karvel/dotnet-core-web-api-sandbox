using System.Collections.Generic;

using Sandbox.Models.Interfaces;
using Sandbox.Models.Repository;
using Sandbox.Models.Role;

namespace Sandbox.Models.DataManager
{
	public class RoleManager : IRoleManager
	{
		readonly IUnitOfWork _unitOfWork;

		public RoleManager(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public IEnumerable<RoleEntity> GetRoles()
		{
			return _unitOfWork.Roles.GetAll();
		}
	}
}
