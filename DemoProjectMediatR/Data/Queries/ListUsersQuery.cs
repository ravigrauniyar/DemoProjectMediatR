using DemoProjectMediatR.Models;
using MediatR;

namespace DemoProjectMediatR.Data.Queries
{
    public class ListUsersQuery: IRequest<IEnumerable<UserEntity>>
    {
    }
}
