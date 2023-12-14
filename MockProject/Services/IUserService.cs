using MockProject.Dtos;
using MockProject.Entities;

namespace MockProject.Services
{
    public interface IUserService
    {
        public ValueTask<bool> CreateUserAsync(UserDto userDto);

        public ValueTask<bool> UpdateUserAsync(int Id,UserDto userDto);
        public ValueTask<bool> DeleteUserAsync(int Id);
        public ValueTask<List<User>> GetAllAsync();
        public ValueTask<User> GetByIdAsync(int Id);
    }
}
