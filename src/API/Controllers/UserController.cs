using API.Application.Commands.User;
using API.Application.Models.User;
using API.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/")]
    public class UserController : ControllerBase
    {
        private IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("user")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserModel input)
        {
            
            var command = new CreateUserCommand(
                input
            );

            var result = await _mediator.Send(command);

            Console.WriteLine($"CreateUser: {input.FirstName}, {input.LastName}");
            return Ok(200);
        }


        [HttpGet]
        [Route("users")]
        public async Task<IActionResult> GetUsers()
        {
            var command = new GetUsersQuery();
            var result = await _mediator.Send(command);

            return result != null ? Ok(result) : NotFound();
        }
    }
}