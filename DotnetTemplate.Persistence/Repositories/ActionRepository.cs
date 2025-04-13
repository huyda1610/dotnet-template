using Dotnet.Application.Interfaces;
using Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotnetTemplate.Persistence.Repositories
{
    public class ActionRepository : RepositoryBase<ActionsEntity>, IActionRepository
    {
        public ActionRepository(IDbContextFactory<ApplicationDbContext> contextFactory)
            : base(contextFactory)
        {
        }
        
    }
}
