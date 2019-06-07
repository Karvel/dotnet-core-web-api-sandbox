using Sandbox.Models;
using Sandbox.Models.Repository;

namespace Sandbox.Models.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UserContext _context;

        public UnitOfWork(UserContext context)
        {
            _context = context;
            Roles = new RoleRepository(_context);
            Users = new UserRepository(_context);
        }

        public IRoleRepository Roles { get; }
        public IUserRepository Users { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
