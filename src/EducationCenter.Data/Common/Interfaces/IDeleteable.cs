namespace EducationCenter.Data.Common.Interfaces;

public interface IDeleteable<T> where T : class
{
    public Task<T> DeleteAsync(long id);
}
