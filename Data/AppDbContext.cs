///
/// Database Connection Model
///

using Microsoft.EntityFrameworkCore;

namespace FinancialLogbook.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Transaction> Transactions { get; set; }
    }
}