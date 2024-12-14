using Infrastructure.Interfaces;
using Domain.UserAggregate;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        /*     private readonly ApplicationDbContext _context;

             public UserRepository(ApplicationDbContext context)
             {
                 _context = context;
             }

             public async Task AddAsync(User user)
             {
                 await _context.Users.AddAsync(user);
                 await _context.SaveChangesAsync();
             }*/
        public Task AddAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}