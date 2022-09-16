using EducationCenter.Data.Repositories;
using EducationCenter.Domain.Common;
using EducationCenter.Domain.Entities;
using EducationCenter.Service.Common.Utils;
using EducationCenter.Service.Interfaces.Services;
using EducationCenter.Service.ViewModels.Positions;
using System.Linq;

namespace EducationCenter.Service.Services.Positions
{
    public class PositionService : IPositionService
    {
        private readonly UnitOfWork _unitOfWork;
        public PositionService()
        {
            _unitOfWork = new UnitOfWork();
        }
        public async Task<BaseResponse<bool>> CreateAsync(Position position)
        {
            var response = new BaseResponse<bool>();
            var oldposition = await _unitOfWork.Positions.FirstOrDefaultAsync(x => x.Name == position.Name);
            if (oldposition is not null)
            {
                response.IsSuccessful = false;
                response.ErrorMessage = $"{position.Name} is already exist!";
            }
            else
            {
                await _unitOfWork.Positions.CreateAsync(position);
                response.IsSuccessful = response.Data = true;
            }
            return response;
        }

        public async Task<BaseResponse<bool>> DeleteAsync(long id)
        {
            var response = new BaseResponse<bool>();
            var position = await _unitOfWork.Positions.FindAsync(id);
            if (position is not null)
            {
                await _unitOfWork.Positions.DeleteAsync(id);
                response.IsSuccessful = response.Data = true;
            }
            else
            {
                response.IsSuccessful = response.Data = false;
                response.ErrorMessage = "Position not found";
            }
            return response;
        }

        public async Task<PagedList<PositionViewModel>> GetAllAsync(PaginationParams @params)
        {
            IQueryable<PositionViewModel> query 
                = from position in await _unitOfWork.Positions.GetAllAsync()
                  select new PositionViewModel {
                    Id = position.Id,
                    Name = position.Name,
                    Status = position.Status.ToString(),
                    CountStaffsOfPosition = _unitOfWork.Positions.CountStaffsAsync(position.Id).Result,
                  };

            return await PagedList<PositionViewModel>
                .ToPagedListAsync(query, @params.PageNumber, @params.PageSize);
        }

        public async Task<BaseResponse<Position>> GetAsync(long id)
        {
            var response = new BaseResponse<Position>();
            var position = await _unitOfWork.Positions.FindAsync(id);
            if (position is not null)
            {
                response.IsSuccessful = true;
                response.Data = position;
            }
            else
            {
                response.IsSuccessful = false;
                response.ErrorMessage = "Position not found";
            }
            return response;
        }

        public Task<BaseResponse<bool>> UpdateAsync(long id, Position position)
        {
            throw new NotImplementedException();
        }
    }
}