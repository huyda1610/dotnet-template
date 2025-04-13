using Dotnet.Application.Interfaces;
using Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotnetTemplate.Persistence.Repositories
{
    public class ActionInFunctionRepository : RepositoryBase<ActionInFunctionsEntity>, IActionInFunctionRepository
    {
        public ActionInFunctionRepository(IDbContextFactory<ApplicationDbContext> contextFactory)
            : base(contextFactory)
        {
        }
        
    }
}
