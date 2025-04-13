using Dotnet.Domain.Entities;

namespace Dotnet.Application.Interfaces
{
    public interface IUserRoleRepository : IRepositoryBase<UserRolesEntity>
    {
        // Task GetAllAsync(Guid guid);
    }
}
