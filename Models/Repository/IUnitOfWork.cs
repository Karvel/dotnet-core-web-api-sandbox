using System;

namespace Sandbox.Models.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IRoleRepository Roles { get; }
        IUserRepository Users { get; }

        int Complete();
    }
}
