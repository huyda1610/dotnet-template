using Dotnet.Application.Interfaces;
using Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotnetTemplate.Persistence;

public class ApplicationDbContext: DbContext, IApplicationDbContext
{
    DbSet<Users> Users { get; set; }
    DbSet<Roles> Roles { get; set; }
    DbSet<Permissions> Permissions { get; set; }
    DbSet<Functions> Functions { get; set; }
    DbSet<ActionInFunctions> ActionInFunctions { get; set; }
    DbSet<Actions> Actions { get; set; }
    DbSet<UserRoles> UserRoles { get; set; }
    DbSet<RoleClaims> RoleClaims { get; set; }
    DbSet<UserClaims> UserClaims { get; set; }
    DbSet<UserLogins> UserLogins { get; set; }
    DbSet<UserTokens> UserTokens { get; set; }
}