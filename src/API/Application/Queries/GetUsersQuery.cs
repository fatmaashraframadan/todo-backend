using MediatR;
using Domain.UserAggregate;

namespace API.Application.Queries
{
    public class GetUsersQuery : IRequest<IEnumerable<User>>
    {
    }
}