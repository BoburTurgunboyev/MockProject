using Microsoft.Identity.Client;
using MockProject.Dtos;
using MockProject.Entities;
using MockProject.Repositories;

namespace MockProject.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async ValueTask<bool> CreateUserAsync(UserDto userDto)
        {
            var user = new User() 
            {
                Name = userDto.Name,    
                Email = userDto.Email,
                Password = userDto.Password,
            };  

            var result = await _userRepository.CreateUserAsync(user);
            return result;

        }

        public async ValueTask<bool> DeleteUserAsync(int Id)
        {
            var res = await _userRepository.DeleteUserAsync(Id);
            return res;
        }

        public async ValueTask<List<User>> GetAllAsync()
        {
            var res = await _userRepository.GetAllAsync();
            return res;
        }

        public async ValueTask<User> GetByIdAsync(int Id)
        {
           var res = await _userRepository.GetByIdAsync(Id);
            return res;
        }

        public async ValueTask<bool> UpdateUserAsync(int Id, UserDto userDto)
        {
            var res = await _userRepository.GetByIdAsync(Id);

            res.Name = userDto.Name;
            res.Email = userDto.Email;
            res.Password = userDto.Password;

            var user = await _userRepository.UpdateUserAsync(res);
            return user;
        }
    }
}
