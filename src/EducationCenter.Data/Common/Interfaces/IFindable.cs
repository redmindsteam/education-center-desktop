using System.Linq.Expressions;

namespace EducationCenter.Data.Common.Interfaces;

public interface IFindable<T> where T : class
{
    public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);

    public Task<T> FindAsync(long id);
}
