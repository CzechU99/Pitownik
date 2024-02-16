using Microsoft.EntityFrameworkCore;
using pitownik.Models;

namespace pitownik.context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<konto> konta { get; set; }

    }

}

