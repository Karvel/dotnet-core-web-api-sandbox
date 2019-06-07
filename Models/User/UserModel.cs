using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Sandbox.Models.Role;
 
namespace Sandbox.Models.User
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public RoleModel Role { get; set; }
        public string Password { get; set; }
    }
}
