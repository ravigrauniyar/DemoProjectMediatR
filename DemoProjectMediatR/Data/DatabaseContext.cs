using DemoProjectMediatR.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoProjectMediatR.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<UserEntity> UsersTable { get; set; }
    }
}
