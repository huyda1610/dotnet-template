using Dotnet.Domain.Entities;

namespace Dotnet.Application.Interfaces
{
    public interface IUserTokenRepository : IRepositoryBase<UserTokensEntity>
    {
        // Task GetAllAsync(Guid guid);
    }
}
