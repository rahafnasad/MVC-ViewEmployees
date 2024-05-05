using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.data
{
    public class AppDbContext: DbContext  
    {
        public DbSet<Emolpyee> employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database = Task1; Trusted_Connection = true; TrustServerCertificate = true");

        }
    }
}
