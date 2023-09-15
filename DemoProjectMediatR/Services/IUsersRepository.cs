
using DemoProjectMediatR.Models;

namespace DemoProjectMediatR.Services
{
    public interface IUsersRepository
    {
        public Task<IEnumerable<UserEntity>> GetUsersList();
        public Task<UserEntity> AddUser(CreateUserModel userModel);
    }
}
