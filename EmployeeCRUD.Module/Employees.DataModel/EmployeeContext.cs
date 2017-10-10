using Employees.Entities;
using System.Data.Entity;

namespace Employees.DataModel
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
