using System.Collections.Generic;

using AutoMapper;

using Sandbox.Models.Interfaces;
using Sandbox.Models.Repository;
using Sandbox.Models.User;

namespace Sandbox.Models.Services
{
	public class UserService : IUserService
	{
		readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public UserService(IMapper mapper, IUnitOfWork unitOfWork)
		{
			_mapper = mapper;
			_unitOfWork = unitOfWork;
		}

		public IEnumerable<UserEntity> GetUsers()
		{
			return _unitOfWork.Users.GetUsersWithRoles();
		}

		public UserEntity GetUser(int id)
		{
			return _unitOfWork.Users.GetUserWithRole(id);
		}

		public void AddUser(UserEntity entity)
		{
			_unitOfWork.Users.Add(entity);
			_unitOfWork.Complete();
		}

		public void UpdateUser(UserEntity user, UserEntity entity)
		{
			user.FirstName = entity.FirstName;
			user.LastName = entity.LastName;
			user.Email = entity.Email;
			_unitOfWork.Users.Update(user, entity);
			_unitOfWork.Complete();
		}

		public void DeleteUser(UserEntity user)
		{
			_unitOfWork.Users.Delete(user);
			_unitOfWork.Complete();
		}
	}
}
