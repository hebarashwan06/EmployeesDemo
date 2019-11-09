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
    public class EmployeesLogic
    {
        public List<EmployeeListVM> GetList()
        {
            return new EmployeesRepository().GetList();
        }

        public Employee GetById(int id)
        {
            return new EmployeesRepository().GetById(id);
        }

        public bool Create(Employee employee)
        {
            return new EmployeesRepository().Create(employee);
        }

        public bool Update(Employee employee)
        {
            return new EmployeesRepository().Update(employee);
        }

        public bool Delete(int id)
        {
            return new EmployeesRepository().Delete(id);
        }





    }
}
