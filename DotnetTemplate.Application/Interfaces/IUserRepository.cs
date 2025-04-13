using Dotnet.Domain.Entities;

namespace Dotnet.Application.Interfaces
{
    public interface IUserRepository : IRepositoryBase<UsersEntity>
    {
        // Task GetAllAsync(Guid guid);
    }
}
