using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
namespace Sandbox.Models.UserRole
{
    public class UserRoleEntity
    {
        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public User.UserEntity User { get; set; }
        public int RoleId { get; set; }
        public Role.RoleEntity Role { get; set; }
    }
}
