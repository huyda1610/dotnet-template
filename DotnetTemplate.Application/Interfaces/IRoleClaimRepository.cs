using Dotnet.Domain.Entities;

namespace Dotnet.Application.Interfaces
{
    public interface IRoleClaimRepository : IRepositoryBase<RoleClaimsEntity>
    {
        // Task GetAllAsync(Guid guid);
    }
}
