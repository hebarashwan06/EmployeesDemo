using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeesDemo.DataMapping.Entities
{
    public class EmployeesDBContext: DbContext
    {
        public EmployeesDBContext():base("EmployeesDBContext")
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
