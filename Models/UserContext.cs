using Microsoft.EntityFrameworkCore;
 
namespace Sandbox.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options)
            : base(options)
        {
        }
 
        public DbSet<User.UserEntity> Users { get; set; }
		public DbSet<Role.RoleEntity> Roles { get; set; }
		public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Role.RoleEntity>().HasData(new Role.RoleEntity
            {
                RoleId = 1,
                Name = "Administrator",
                Description= "",
            }, new Role.RoleEntity
            {
                RoleId = 2,
                Name = "Consumer",
                Description= "",
            });
            modelBuilder.Entity<User.UserEntity>().HasData(new User.UserEntity
            {
                UserId = 1,
                Email = "test@test.com",
                FirstName= "Elanna",
                LastName= "Grossman",
                PasswordHash = null,
            });
        }
    }
}
