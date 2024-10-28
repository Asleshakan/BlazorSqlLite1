using BlazorSqlLite1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorSqlLite1.dbcontext
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(@"Data Source =wwwroot\Demo.db");
        public DbSet<Wallet> wallets {  get; set; }
    }
}
