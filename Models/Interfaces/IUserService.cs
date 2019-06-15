using System.Collections.Generic;

using Sandbox.Models.User;

namespace Sandbox.Models.Interfaces
{
	public interface IUserService
	{
		IEnumerable<UserEntity> GetUsers();
		UserEntity GetUser(int id);
		void AddUser(UserEntity entity);
		void UpdateUser(UserEntity user, UserEntity entity);
		void DeleteUser(UserEntity user);
	}
}
