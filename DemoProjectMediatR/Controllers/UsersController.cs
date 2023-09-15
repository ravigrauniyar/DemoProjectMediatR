using DemoProjectMediatR.Data.Commands;
using DemoProjectMediatR.Data.Queries;
using DemoProjectMediatR.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DemoProjectMediatR
{
    [ApiController]
    [Route("/api/[Controller]/")]
    public class UserController: Controller
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("list")]

        public async Task<IActionResult> ListUsers()
        {
            return Ok(await _mediator.Send(new ListUsersQuery()));
        }

        [HttpPost]

        public async Task<IActionResult> CreateUser([FromBody] CreateUserModel userModel)
        {
            return Ok(await _mediator.Send(new CreateUserCommand(userModel)));
        }
    }
}
