using GenericWithIdentityModel.Data.Model;
using GenericWithIdentityModel.Data.Patterns.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GenericWithIdentityModel.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        EmployeeRepository _service;
        public EmployeeController(EmployeeRepository service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Employee> emp = await _service.GetAll();
            return View(emp);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee item)
        {
            _service.Add(item);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            return RedirectToAction("Index");
        }
    }
}
