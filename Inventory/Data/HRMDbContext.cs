using Inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data
{
    public class HRMDbContext : DbContext
    {
        public HRMDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public object Emplolyees { get; internal set; }
    }
}
