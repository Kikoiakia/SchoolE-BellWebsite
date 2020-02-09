using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class SongDb : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-9F6IC4T\SQLEXPRESS;
            Initial Catalog=SongDb;
            TRUSTED_CONNECTION = TRUE");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
