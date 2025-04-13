using Dotnet.Application.Interfaces;
using Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotnetTemplate.Persistence.Repositories
{
    public class RoleRepository : RepositoryBase<RolesEntity>, IRoleRepository
    {
        public RoleRepository(IDbContextFactory<ApplicationDbContext> contextFactory)
            : base(contextFactory)
        {
        }
        
    }
}
