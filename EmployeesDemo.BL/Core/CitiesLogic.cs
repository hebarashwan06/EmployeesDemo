using EmployeesDemo.DAL.Repositories;
using EmployeesDemo.DataMapping.Entities;
using EmployeesDemo.DataMapping.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDemo.BL.Core
{
    public class CitiesLogic
    {
        public List<CityVM> GetListByCountryId(int countryId)
        {
            return new CitiesRepository().GetListByCountryId(countryId);
        }

        public List<City> GetList()
        {
            return new CitiesRepository().GetList();
        }

    }
}
