using EducationCenter.Data.DbContexts;
using EducationCenter.Data.Interfaces.Users;
using EducationCenter.Domain.Entities;

namespace EducationCenter.Data.Repositories.Users
{
    public class UserRepository : GenericRepository<User>,
        IUserRepository
    {
        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}