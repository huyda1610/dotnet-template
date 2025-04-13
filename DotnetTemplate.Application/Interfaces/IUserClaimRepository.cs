using Dotnet.Domain.Entities;

namespace Dotnet.Application.Interfaces
{
    public interface IUserClaimRepository : IRepositoryBase<UserClaimsEntity>
    {
        // Task GetAllAsync(Guid guid);
    }
}
