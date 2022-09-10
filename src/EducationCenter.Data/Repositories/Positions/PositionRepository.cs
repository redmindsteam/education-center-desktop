using EducationCenter.Data.Interfaces.Positions;
using EducationCenter.Domain.Entities;

namespace EducationCenter.Data.Repositories.Positions
{
    public class PositionRepository : GenericRepository<Position>, 
        IPositionRepository
    {
    }
}