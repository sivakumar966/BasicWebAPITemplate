using Microsoft.EntityFrameworkCore;

namespace GamesStoreServer.Domains
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
