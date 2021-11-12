
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class AppDataContext : DbContext
    {

        public AppDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
        
        
    }
}