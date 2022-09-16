using EducationCenter.Domain.Common;
using EducationCenter.Domain.Entities;
using EducationCenter.Service.Common.Utils;
using EducationCenter.Service.ViewModels.Positions;

namespace EducationCenter.Service.Interfaces.Services;

public interface IPositionService
{
    public Task<PagedList<PositionViewModel>> GetAllAsync(PaginationParams @params);

    public Task<BaseResponse<Position>> GetAsync(long id);

    public Task<BaseResponse<bool>> CreateAsync(Position position);

    public Task<BaseResponse<bool>> UpdateAsync(long id, Position position);

    public Task<BaseResponse<bool>> DeleteAsync(long id);
}
