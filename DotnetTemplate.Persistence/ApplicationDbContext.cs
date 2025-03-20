using Dotnet.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DotnetTemplate.Persistence;

public class ApplicationDbContext: DbContext, IApplicationDbContext
{
    
}