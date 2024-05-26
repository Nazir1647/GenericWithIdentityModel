using GenericWithIdentityModel.Data.Patterns.Repository;
using GenericWithIdentityModel.Data.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace GenericWithIdentityModel.Controllers
{
    public class RegistrationController : Controller
    {
        RegistrationRepository _service;

        public RegistrationController(RegistrationRepository service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(RegistrationVM vm)
        {
            _service.Add(vm);
            return View();
        }
    }
}
