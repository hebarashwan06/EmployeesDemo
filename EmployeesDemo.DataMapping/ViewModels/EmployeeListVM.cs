using EmployeesDemo.DataMapping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDemo.DataMapping.ViewModels
{
    public class EmployeeListVM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public DateTime? Birthdate { get; set; }

        public int? CityId { get; set; }

        public string CiyName { get; set; }
    }
}
