using Microsoft.EntityFrameworkCore;
using web_assignment2.Models;

namespace web_assignment2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Customerinfo> Customerinfo { get; set; }
    }
}
