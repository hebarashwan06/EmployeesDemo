using EmployeesDemo.DAL.Repositories;
using EmployeesDemo.DataMapping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDemo.BL.Core
{
    public class CountriesLogic
    {
        public List<Country> GetList()
        {
            return new CountriesRepository().GetList();
        }
    }
}
