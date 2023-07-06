using Microsoft.EntityFrameworkCore;

namespace AkademiPlusSignalRAPI.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NODIFQV\\SQLEXPRESS; initial catalog=SignalRDb; integrated security=true");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
