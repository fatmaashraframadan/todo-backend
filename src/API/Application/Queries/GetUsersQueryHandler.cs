using Domain.UserAggregate;
using Infrastructure.Interfaces;
using MediatR;

namespace API.Application.Queries
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, IEnumerable<User>>
    {
        private readonly IUserRepository _userRepository;

        public GetUsersQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            //return await _userRepository.GetUsers();
            throw new NotImplementedException();
        }
    }
}