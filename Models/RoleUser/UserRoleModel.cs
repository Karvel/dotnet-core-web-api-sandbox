using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
namespace Sandbox.Models.UserRole
{
    public class UserRoleModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User.UserModel User { get; set; }
        public int RoleId { get; set; }
        public Role.RoleModel Role { get; set; }
    }
}
