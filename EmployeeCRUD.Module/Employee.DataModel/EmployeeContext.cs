using System.Data.Entity;
using Employees.Entities;

namespace Employee.DataModel
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
