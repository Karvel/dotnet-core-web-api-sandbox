using System;

namespace Sandbox.Models.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRoleRepository Roles { get; }
        IUserRepository Users { get; }

        int Complete();
    }
}
