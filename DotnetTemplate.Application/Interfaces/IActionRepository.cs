using Dotnet.Domain.Entities;

namespace Dotnet.Application.Interfaces
{
    public interface IActionRepository : IRepositoryBase<ActionsEntity>
    {
        // Task GetAllAsync(Guid guid);
    }
}
