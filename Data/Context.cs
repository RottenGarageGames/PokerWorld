using Microsoft.EntityFrameworkCore;

namespace PokerWorld.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
        : base(options)
        {
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
