using DemoProjectMediatR.Models;
using MediatR;

namespace DemoProjectMediatR.Data.Commands
{
    // Define Command class to be sent to MediatR that expects an instance of UserEntity in return
    public class CreateUserCommand: IRequest<UserEntity>
    {
        // Field declaration of expected model
        public CreateUserModel userModel;
        public CreateUserCommand(CreateUserModel createUserModel)
        {
            // Usermodel Field initialization
            userModel = createUserModel;
        }
    }
}
