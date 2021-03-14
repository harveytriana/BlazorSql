// ======================================
//  Blazor Spread. LHTV
// ======================================
using BlazorSql.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorSql.Server.Services
{
    public class SqlContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public SqlContext(DbContextOptions<SqlContext> options)
            : base(options) { }
    }
}
