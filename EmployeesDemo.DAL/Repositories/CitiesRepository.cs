using EmployeesDemo.DataMapping.Entities;
using EmployeesDemo.DataMapping.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDemo.DAL.Repositories
{
    public class CitiesRepository
    {
        public List<CityVM> GetListByCountryId(int countryId)
        {
            using (var db = new EmployeesDBContext())
            {
                return db.Cities.Where(c => c.CountryId == countryId).Select(c=>new CityVM
                {
                    Id=c.Id,
                    Name=c.Name
                }).ToList();
            }
        }

        public List<City> GetList()
        {
            using (var db = new EmployeesDBContext())
            {
                return db.Cities.ToList();
            }

        }

    }
}
