namespace EducationCenter.Data.Common.Interfaces;

public interface IUpdateable<T> where T : class
{
    public Task<T> UpdateAsync(long id, T entity);
}
