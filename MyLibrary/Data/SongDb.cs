using Data.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class SongDb : IdentityDbContext
    {
        public DbSet<Song> Songs { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=KIRIL-LAPTOP\SQLEXPRESS;
            Initial Catalog=SongDb;
            TRUSTED_CONNECTION = TRUE");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
