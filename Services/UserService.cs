using Autoshop.Models;
using Autoshop.Repositories;

namespace Autoshop.Services
{
    public class UserService : IUserService<User>
    {
        private Repository<User> repository;

        public async Task<User> AddUserAsync(User user)
        {
            await repository.AddAsync(user);

            return user;
        }
    }
}
