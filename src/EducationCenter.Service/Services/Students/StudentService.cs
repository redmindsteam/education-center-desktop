using EducationCenter.Data.Interfaces;
using EducationCenter.Data.Repositories;
using EducationCenter.Domain.Common;
using EducationCenter.Domain.Entities;
using EducationCenter.Service.Common.Utils;
using EducationCenter.Service.Interfaces.Services;
using EducationCenter.Service.Services.Common;
using EducationCenter.Service.ViewModels.Students;

namespace EducationCenter.Service.Services.Students
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly FileService _fileService;
        public StudentService()
        {
            this._unitOfWork = new UnitOfWork();
            this._fileService = new FileService();
        }
        public async Task<BaseResponse<bool>> CreateAsync(Student student)
        {
            var result = new BaseResponse<bool>();
            if (File.Exists(student.ImagePath))
            {
                var fileServiceResult = await _fileService.CopyImageAsync(student.ImagePath);
                if (fileServiceResult.IsSuccessful) student.ImagePath = fileServiceResult.Message;
                else
                {
                    result.IsSuccessful = false;
                    result.ErrorMessage = fileServiceResult.Message;
                    return result;
                }
            }
            student.BirthDate = null;
            var res = await _unitOfWork.Students.CreateAsync(student);
            await _unitOfWork.SaveChangesAsync();
            result.IsSuccessful = true;
            return result;
        }

        public Task<BaseResponse<bool>> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedList<StudentViewModel>> GetAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Student>> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<bool>> UpdateAsync(long id, Student student)
        {
            throw new NotImplementedException();
        }
    }
}