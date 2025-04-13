using Dotnet.Application.Interfaces;
using Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotnetTemplate.Persistence.Repositories
{
    public class UserClaimRepository : RepositoryBase<UserClaimsEntity>, IUserClaimRepository
    {
        public UserClaimRepository(IDbContextFactory<ApplicationDbContext> contextFactory)
            : base(contextFactory)
        {
        }
        
    }
}
