namespace EducationCenter.Data.Common.Interfaces;

public interface ICreateable<T> where T : class
{
    public Task<T> CreateAsync(Task entity);
}
