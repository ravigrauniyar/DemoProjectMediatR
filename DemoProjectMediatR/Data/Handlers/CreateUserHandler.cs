using DemoProjectMediatR.Data.Commands;
using DemoProjectMediatR.Models;
using DemoProjectMediatR.Services;
using MediatR;

namespace NewApiProject.Data.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, UserEntity>
    {
        private readonly IUsersRepository _usersRepository;
        public CreateUserHandler(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        public async Task<UserEntity> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            return await _usersRepository.AddUser(request.userModel);
        }
    }
}
