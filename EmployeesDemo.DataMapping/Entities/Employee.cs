using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDemo.DataMapping.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage ="Name Can't exceed 50 char")]
        public string Name { get; set; }

        public Gender Gender { get; set; }
        public DateTime? Birthdate { get; set; }

        public int? CityId { get; set; }
        public virtual City City { get; set; }
    }

    public enum Gender
    {
        Male,Female
    }
}
