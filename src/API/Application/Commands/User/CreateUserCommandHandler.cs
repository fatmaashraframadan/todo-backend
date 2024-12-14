using Domain.UserAggregate;
using Infrastructure.Interfaces;
using MediatR;

namespace API.Application.Commands.User
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
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

            await _userRepository.AddAsync(user);
            return user.Id;
        }
    }
}