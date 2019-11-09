using EmployeesDemo.DataMapping.Entities;
using EmployeesDemo.DataMapping.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDemo.DAL.Repositories
{
    public class EmployeesRepository
    {
        public List<EmployeeListVM> GetList()
        {
            using (var db = new EmployeesDBContext())
            {
                var employees = db.Employees.Select(e => new EmployeeListVM
                {
                    Id=e.Id,
                    Name=e.Name,
                    Gender=e.Gender,
                    Birthdate=e.Birthdate,
                    CityId=e.CityId,
                    CiyName=e.CityId!=null?e.City.Name:null

                }).ToList();
                return employees;
            }
        }

        public Employee GetById(int id)
        {
            using (var db = new EmployeesDBContext())
            {
                return db.Employees.FirstOrDefault(e=>e.Id==id);
            }
        }

        public bool Create(Employee employee)
        {
            using (var db=new EmployeesDBContext())
            {
                try
                {
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    return true;
                }
                catch 
                {
                    return false;
                }
            }
        }

        public bool Update(Employee employee)
        {
            using (var db = new EmployeesDBContext())
            {
                try
                {
                    var q = db.Employees.FirstOrDefault(e=>e.Id==employee.Id);
                    if (q!=null)
                    {
                        q.Id = employee.Id;
                        q.Name = employee.Name;
                        q.Gender = employee.Gender;
                        q.Birthdate = employee.Birthdate;
                        q.CityId = employee.CityId;
                        db.SaveChanges();
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool Delete(int id)
        {
            using (var db = new EmployeesDBContext())
            {
                try
                {
                    var q = db.Employees.FirstOrDefault(x => x.Id == id);
                    if (q != null)
                    {
                        db.Employees.Remove(q);
                        db.SaveChanges();
                    }
                    return true;
                }
                catch 
                {
                    return false;
                }
            }
        }


    }
}
