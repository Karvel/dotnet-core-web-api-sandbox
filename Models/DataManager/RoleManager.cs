using System.Collections.Generic;
using System.Linq;

using Sandbox.Models.Repository;
using Sandbox.Models.Role;

namespace Sandbox.Models.DataManager
{
	public class RoleManager : RoleRepository
	{
		readonly IUnitOfWork _unitOfWork;

		public RoleManager(UserContext context, IUnitOfWork unitOfWork) : base(context)
		{
			_unitOfWork = unitOfWork;
		}

		public IEnumerable<RoleEntity> GetRoles()
		{
			return _unitOfWork.Roles.GetAll();
		}
	}
}
