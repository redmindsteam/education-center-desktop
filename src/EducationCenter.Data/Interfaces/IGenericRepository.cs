using EducationCenter.Data.Common.Interfaces;

namespace EducationCenter.Data.Interfaces;

public interface IGenericRepository<T> 
    : ICreateable<T>, IFindable<T>, ISearchable<T>,
    IUpdateable<T>, IDeleteable<T> where T : class
{
    Task<IQueryable<T>> GetAllAsync();
}
