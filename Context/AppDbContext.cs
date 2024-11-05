using Identity_DataProtection_Jwt.Entites;
using Microsoft.EntityFrameworkCore;

namespace Identity_DataProtection_Jwt.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<UserEntity> Users => Set<UserEntity>();
    }
}
