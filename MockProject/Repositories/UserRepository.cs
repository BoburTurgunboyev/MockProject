using Microsoft.EntityFrameworkCore;
using MockProject.DataAccess;
using MockProject.Entities;

namespace MockProject.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbConntext _appDbConntext;

        public UserRepository(AppDbConntext appDbConntext)
        {
            _appDbConntext = appDbConntext;
        }

        public async ValueTask<bool> CreateUserAsync(User user)
        {
            await _appDbConntext.Users.AddAsync(user);
            var result = await _appDbConntext.SaveChangesAsync();
            return result > 0;
        }

        public async ValueTask<bool> DeleteUserAsync(int id)
        {
            var res = await _appDbConntext.Users.FirstOrDefaultAsync(x => x.Id == id);
            _appDbConntext.Users.Remove(res);
            var result = await _appDbConntext.SaveChangesAsync();
            return result > 0;
        }

        public async ValueTask<List<User>> GetAllAsync()
        {
            var res = await _appDbConntext.Users.ToListAsync();
            return res;
        }

        public async ValueTask<User> GetByIdAsync(int id)
        {
            var res =  await _appDbConntext.Users.FirstOrDefaultAsync(x => x.Id == id);
            return res ;
        }

        public async ValueTask<bool> UpdateUserAsync(User user)
        {
            var res = await _appDbConntext.Users.FirstOrDefaultAsync(x =>x.Id == user.Id);
            if (res == null) { return false; }

            _appDbConntext.Users.Update(res);
            var result = await _appDbConntext.SaveChangesAsync();
            return result > 0;
        }
    }
}
