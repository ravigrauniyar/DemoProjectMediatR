using DemoProjectMediatR.Data.Queries;
using DemoProjectMediatR.Models;
using DemoProjectMediatR.Services;
using MediatR;

namespace DemoProjectMediatR.Data.Handlers
{
    public class ListUsersHandler : IRequestHandler<ListUsersQuery, IEnumerable<UserEntity>>
    {
        private readonly IUsersRepository _usersRepository;
        public ListUsersHandler(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        public async Task<IEnumerable<UserEntity>> Handle(ListUsersQuery request, CancellationToken cancellationToken)
        {
            return await _usersRepository.GetUsersList();
        }
    }
}
