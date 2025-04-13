using Dotnet.Domain.Entities;

namespace Dotnet.Application.Interfaces
{
    public interface IFunctionRepository : IRepositoryBase<FunctionsEntity>
    {
        // Task GetAllAsync(Guid guid);
    }
}
