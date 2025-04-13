using Dotnet.Domain.Entities;

namespace Dotnet.Application.Interfaces
{
    public interface IRoleRepository : IRepositoryBase<RolesEntity>
    {
        // Task GetAllAsync(Guid guid);
    }
}
