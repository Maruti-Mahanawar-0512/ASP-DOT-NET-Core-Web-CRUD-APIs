using ASP_DOT_NET_Core_Web_APIs.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP_DOT_NET_Core_Web_APIs.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> AccountUsers { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
