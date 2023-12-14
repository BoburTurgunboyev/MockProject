using MockProject.Dtos;
using MockProject.Entities;

namespace MockProject.Repositories
{
    public interface IUserRepository
    {
        public ValueTask<bool> CreateUserAsync(User user);
        public ValueTask<bool> UpdateUserAsync(User user);
        public ValueTask<bool> DeleteUserAsync(int id);
        public ValueTask<List<User>> GetAllAsync();   
        public ValueTask<User> GetByIdAsync(int id);
    }
}
