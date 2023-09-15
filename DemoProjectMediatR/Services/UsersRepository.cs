using DemoProjectMediatR.Data;
using DemoProjectMediatR.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoProjectMediatR.Services
{
    public class UsersRepository : IUsersRepository
    {
        private readonly DatabaseContext _databaseContext;

        public UsersRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<UserEntity> AddUser(CreateUserModel userModel)
        {
            var user = new UserEntity
            {
                id = Guid.NewGuid(),
                name = userModel.userName,
                address = userModel.address
            };
            _databaseContext.Add(user);
            await _databaseContext.SaveChangesAsync();

            return user;
        }

        public async Task<IEnumerable<UserEntity>> GetUsersList()
        {
            return await _databaseContext.UsersTable.ToListAsync();
        }
    }
}
