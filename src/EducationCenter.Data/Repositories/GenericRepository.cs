using EducationCenter.Data.Interfaces;
using System.Linq.Expressions;

namespace EducationCenter.Data.Repositories;

public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
{
    public Task<T> CreateAsync(Task entity)
    {
        throw new NotImplementedException();
    }

    public Task<T> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<T> FindAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<T> UpdateAsync(long id, T entity)
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<T>> WhereAsync(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }
}
