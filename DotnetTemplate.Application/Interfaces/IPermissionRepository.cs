using Dotnet.Domain.Entities;

namespace Dotnet.Application.Interfaces
{
    public interface IPermissionRepository : IRepositoryBase<PermissionsEntity>
    {
        // Task GetAllAsync(Guid guid);
    }
}
