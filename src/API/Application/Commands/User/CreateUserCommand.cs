using API.Application.Models.User;
using MediatR;

namespace API.Application.Commands.User
{
    public class CreateUserCommand : IRequest<Guid>
    {
        public CreateUserModel Input { get; set; }

        public CreateUserCommand(CreateUserModel input)
        {
            Input = input;
        }
    }
}