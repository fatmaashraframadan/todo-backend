using Domain.UserAggregate;

namespace Infrastructure.Interfaces
{
    public interface IUserRepository
    {
        Task<Guid> AddAsync(User user);
    }
}