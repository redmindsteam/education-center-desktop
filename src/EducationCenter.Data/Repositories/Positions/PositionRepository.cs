using EducationCenter.Data.DbContexts;
using EducationCenter.Data.Interfaces.Positions;
using EducationCenter.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EducationCenter.Data.Repositories.Positions
{
    public class PositionRepository : GenericRepository<Position>,
        IPositionRepository
    {
        public async Task<int> CountStaffsAsync(long positionId)
        {
            var position = await _dbContext.Positions.FindAsync(positionId);
            if (position is null) return 0;
            else
            {
                if (position.Name.ToLower() == "teacher")
                    return await _dbContext.Teachers.CountAsync();
                else 
                    return await _dbContext.Employees.Where(x=>x.PositionId==positionId)
                        .CountAsync();

            }
        }
    }
}