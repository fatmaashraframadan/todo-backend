
using Domain.UserAggregate;

namespace Infrastructure.Interfaces
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
    }
}