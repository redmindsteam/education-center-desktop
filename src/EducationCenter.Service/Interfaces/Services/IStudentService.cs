using EducationCenter.Domain.Common;
using EducationCenter.Domain.Entities;
using EducationCenter.Service.Common.Utils;
using EducationCenter.Service.ViewModels.Students;

namespace EducationCenter.Service.Interfaces.Services
{
    public interface IStudentService
    {
        public Task<PagedList<StudentViewModel>> GetAllAsync(PaginationParams @params);

        public Task<BaseResponse<Student>> GetAsync(long id);

        public Task<BaseResponse<bool>> CreateAsync(Student student);

        public Task<BaseResponse<bool>> UpdateAsync(long id, Student student);

        public Task<BaseResponse<bool>> DeleteAsync(long id);
    }
}