

using Domain.UserAggregate;
using Infrastructure.Interfaces;
using MediatR;

namespace API.Application.Commands.User
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMediator _mediator;

        public CreateUserCommandHandler(IUserRepository userRepository, IMediator mediator)
        {
            _userRepository = userRepository;
            _mediator = mediator;
        }

        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new Domain.UserAggregate.User(
                request.Input.FirstName,
                request.Input.LastName,
                request.Input.Email,
                request.Input.Password,
                UserRole.Admin
            );

            //  await _userRepository.AddAsync(user);
            return new Guid();//user.Id;
        }
    }
}