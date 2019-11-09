using EmployeesDemo.BL.Core;
using EmployeesDemo.DataMapping.Entities;
using System.Web.Mvc;

namespace EmployeesDemo.Controllers
{
    public class EmployeesController : Controller
    {
        public ActionResult Index()
        {
            var employees = new EmployeesLogic().GetList();
            return View(employees);
        }

        public ActionResult Create()
        {
            ViewBag.Countries = new SelectList(new CountriesLogic().GetList(), "Id", "Name");
            return View();
        }
    
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                new EmployeesLogic().Create(employee);
                return RedirectToAction("Index");
            }
            ViewBag.Countries = new SelectList(new CountriesLogic().GetList(), "Id", "Name", "--Select Country--");
            return View(employee);
        }

        public ActionResult Edit(int id)
        {
            var model = new EmployeesLogic().GetById(id);
            ViewBag.Countries = new SelectList(new CountriesLogic().GetList(), "Id", "Name");
            ViewBag.Cities = new SelectList(new CitiesLogic().GetList(), "Id", "Name",model.CityId);

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                new EmployeesLogic().Update(employee);
                return RedirectToAction("Index");
            }
            ViewBag.Countries = new SelectList(new CountriesLogic().GetList(), "Id", "Name", "--Select Country--");
            ViewBag.Cities = new SelectList(new CitiesLogic().GetList(), "Id", "Name");

            return View(employee);
        }

        public ActionResult Delete(int id)
        {
            new EmployeesLogic().Delete(id);
            return RedirectToAction("Index");
        }

        public JsonResult GetCitiesByCountryId(int countryId)
        {
            var cities = new CitiesLogic().GetListByCountryId(countryId);
            return Json(cities,JsonRequestBehavior.AllowGet);
        }
    }
}