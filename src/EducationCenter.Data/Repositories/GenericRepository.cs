using EducationCenter.Data.DbContexts;
using EducationCenter.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EducationCenter.Data.Repositories;

#pragma warning disable
public abstract class GenericRepository<T> 
    : IGenericRepository<T> where T : class
{
    protected readonly AppDbContext _dbContext;
    protected DbSet<T> _dbSet;
    public GenericRepository()
    {
        _dbContext = new AppDbContext();
        _dbSet = _dbContext.Set<T>();
    }

    public virtual async Task<T> CreateAsync(T entity)
    {
        var entry = await _dbSet.AddAsync(entity);
        return entry.Entity;
    }

    public virtual async Task<T> DeleteAsync(long id)
    {
        var entity = await _dbSet.FindAsync(id);
        _dbSet.Remove(entity);
        return entity;
    }

    public virtual async Task<T> FindAsync(long id)
    {
        var entity = await _dbSet.FindAsync(id);
        return entity;
    }

    public virtual async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
    {
        var entity = await _dbSet.FirstOrDefaultAsync(predicate);
        return entity;
    }

    public virtual async Task<IQueryable<T>> GetAllAsync()
    {
        return _dbSet;
    }

    public virtual async Task<T> UpdateAsync(long id, T entity)
    {
        return _dbSet.Update(entity).Entity;
    }

    public virtual async Task<IQueryable<T>> WhereAsync(Expression<Func<T, bool>> predicate)
    {
        return predicate == null ? _dbSet : _dbSet.Where(predicate);
    }
}
