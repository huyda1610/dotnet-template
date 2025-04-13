using System.Linq.Expressions;
using Dotnet.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DotnetTemplate.Persistence.Repositories;

public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
{
    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;
    protected readonly DbSet<TEntity> _dbSet;

    protected RepositoryBase(IDbContextFactory<ApplicationDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
        using var context = _contextFactory.CreateDbContext();
        _dbSet = context.Set<TEntity>();
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        await using var context = _contextFactory.CreateDbContext();
        var entity = await context.Set<TEntity>().FindAsync(id);
    
        if (entity == null)
            throw new KeyNotFoundException($"Entity with ID {id} not found");
        
        return entity;
    }
    
    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        using var context = _contextFactory.CreateDbContext();
        return await context.Set<TEntity>().ToListAsync();
    }

    public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
    {
        using var context = _contextFactory.CreateDbContext();
        return await context.Set<TEntity>().Where(predicate).ToListAsync();
    }

    public async Task AddAsync(TEntity entity)
    {
        using var context = _contextFactory.CreateDbContext();
        await context.Set<TEntity>().AddAsync(entity);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TEntity entity)
    {
        using var context = _contextFactory.CreateDbContext();
        context.Set<TEntity>().Update(entity);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(TEntity entity)
    {
        using var context = _contextFactory.CreateDbContext();
        context.Set<TEntity>().Remove(entity);
        await context.SaveChangesAsync();
    }
}