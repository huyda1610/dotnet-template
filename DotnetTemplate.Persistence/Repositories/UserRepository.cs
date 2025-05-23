﻿using Dotnet.Application.Interfaces;
using Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotnetTemplate.Persistence.Repositories
{
    public class UserRepository : RepositoryBase<UsersEntity>, IUserRepository
    {
        public UserRepository(IDbContextFactory<ApplicationDbContext> contextFactory)
            : base(contextFactory)
        {
        }
        
    }
}
