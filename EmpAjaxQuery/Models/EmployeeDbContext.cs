using Microsoft.EntityFrameworkCore;

namespace EmpAjaxQuery.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        { }

        public DbSet<EmployeeModel> Employee { get; set; }
    }
}
