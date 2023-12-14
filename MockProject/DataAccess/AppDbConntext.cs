using Microsoft.EntityFrameworkCore;
using MockProject.Entities;

namespace MockProject.DataAccess
{
    public class AppDbConntext : DbContext
    {
        public AppDbConntext(DbContextOptions<AppDbConntext> options) :base(options)
        {
            
        }


        public DbSet<User> Users { get; set; } 
    }
}
