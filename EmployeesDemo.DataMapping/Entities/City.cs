using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDemo.DataMapping.Entities
{
    public class City
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int? CountryId { get; set; }
        public virtual Country Country { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }
    }
}
