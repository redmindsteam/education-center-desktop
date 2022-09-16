using EducationCenter.Domain.Entities;

namespace EducationCenter.Data.Interfaces.Positions;

public interface IPositionRepository : IGenericRepository<Position>
{
    public Task<int> CountStaffsAsync(long positionId);
}
