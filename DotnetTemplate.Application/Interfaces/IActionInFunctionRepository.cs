using Dotnet.Domain.Entities;

namespace Dotnet.Application.Interfaces
{
    public interface IActionInFunctionRepository : IRepositoryBase<ActionInFunctionsEntity>
    {
        // Task GetAllAsync(Guid guid);
    }
}
