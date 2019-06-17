using Microsoft.EntityFrameworkCore;

using Sandbox.Models.Role;
using Sandbox.Models.User;
using Sandbox.Models.UserRole;
 
namespace Sandbox.DataAccess
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options)
            : base(options)
        {
        }
 
        public DbSet<UserEntity> Users { get; set; }
		public DbSet<RoleEntity> Roles { get; set; }
		public DbSet<UserRoleEntity> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<RoleEntity>().HasData(new RoleEntity
            {
                Id = 1,
                Name = "Administrator",
                Description= "",
            }, new RoleEntity
            {
                Id = 2,
                Name = "Consumer",
                Description= "",
            });
            modelBuilder.Entity<UserEntity>().HasData(new UserEntity
            {
                Id = 1,
                Email = "test@test.com",
                FirstName= "Elanna",
                LastName= "Grossman",
                PasswordHash = null,
            }, new UserEntity
            {
                Id = 2,
                Email = "admin@admin.com",
                FirstName= "Corey",
                LastName= "Shuman",
                PasswordHash = null,
            });
            modelBuilder.Entity<UserRoleEntity>().HasData(new UserRoleEntity
            {
                Id = 1,
                UserId = 1,
                RoleId = 2,
            }, new UserRoleEntity
            {
                Id = 2,
                UserId = 2,
                RoleId = 1,
            });
        }
    }
}
