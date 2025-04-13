using Dotnet.Application.Interfaces;
using Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotnetTemplate.Persistence.Repositories
{
    public class UserTokenRepository : RepositoryBase<UserTokensEntity>, IUserTokenRepository
    {
        public UserTokenRepository(IDbContextFactory<ApplicationDbContext> contextFactory)
            : base(contextFactory)
        {
        }
        
    }
}
