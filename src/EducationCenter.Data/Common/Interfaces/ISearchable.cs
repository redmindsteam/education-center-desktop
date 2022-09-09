using System.Linq.Expressions;

namespace EducationCenter.Data.Common.Interfaces;

public interface ISearchable<T> where T :class 
{
    public Task<IQueryable<T>> WhereAsync(Expression<Func<T, bool>> predicate);
}
