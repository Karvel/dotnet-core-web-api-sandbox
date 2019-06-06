using System.Collections.Generic;
using System.Linq;

using Sandbox.Models.Repository;

namespace Sandbox.Models.DataManager
{
	public class UserManager : UserRepository
	{
		readonly IUnitOfWork _unitOfWork;

		public UserManager(UserContext context, IUnitOfWork unitOfWork) : base(context)
		{
			_unitOfWork = unitOfWork;
		}

		public IEnumerable<User> GetUsers()
		{
			return _unitOfWork.Users.GetAll();
		}

		public User Get(int id)
		{
			return _unitOfWork.Users.GetById(id);
		}

		public void AddUser(User entity)
		{
			_unitOfWork.Users.Add(entity);
			_unitOfWork.Complete();
		}

		public void UpdateUser(User user, User entity)
		{
			user.FirstName = entity.FirstName;
			user.LastName = entity.LastName;
			user.Email = entity.Email;
			_unitOfWork.Users.Update(user, entity);
			_unitOfWork.Complete();
		}

		public void DeleteUser(User user)
		{
			_unitOfWork.Users.Delete(user);
			_unitOfWork.Complete();
		}
	}
}
