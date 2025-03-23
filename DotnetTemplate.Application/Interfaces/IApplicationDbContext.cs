using Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dotnet.Application.Interfaces;

public interface IApplicationDbContext
{
    DbSet<UsersEntity> Users { get; set; }
    DbSet<RolesEntity> Roles { get; set; }
    DbSet<PermissionsEntity> Permissions { get; set; }
    DbSet<FunctionsEntity> Functions { get; set; }
    DbSet<ActionInFunctionsEntity> ActionInFunctions { get; set; }
    DbSet<ActionsEntity> Actions { get; set; }
    DbSet<UserRolesEntity> UserRoles { get; set; }
    DbSet<RoleClaimsEntity> RoleClaims { get; set; }
    DbSet<UserClaimsEntity> UserClaims { get; set; }
    DbSet<UserLoginsEntity> UserLogins { get; set; }
    DbSet<UserTokensEntity> UserTokens { get; set; }
}