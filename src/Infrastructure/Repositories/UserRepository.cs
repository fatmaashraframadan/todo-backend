using Infrastructure.Interfaces;
using Domain.UserAggregate;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BaseContext<User> _userContext;

        public UserRepository(BaseContext<User> userContext)
        {
            _userContext = userContext;
        }

        public async Task<Guid> AddAsync(User user)
        {
            await _userContext.Collection.InsertOneAsync(user);
            return user.Id;
        }
    }
}