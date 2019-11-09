using EmployeesDemo.DataMapping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDemo.DAL.Repositories
{
    public class CountriesRepository
    {
        public List<Country> GetList()
        {
            using (var db=new EmployeesDBContext())
            {
                return db.Countries.ToList();
            }
        }
    }
}
