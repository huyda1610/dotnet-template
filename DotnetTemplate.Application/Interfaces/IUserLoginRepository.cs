using Dotnet.Domain.Entities;

namespace Dotnet.Application.Interfaces
{
    public interface IUserLoginRepository : IRepositoryBase<UserLoginsEntity>
    {
        // Task GetAllAsync(Guid guid);
    }
}
