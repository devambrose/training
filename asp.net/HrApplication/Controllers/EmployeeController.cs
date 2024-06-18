using HrApplication.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HrApplication.Controllers
{
    public class EmployeeController : Controller
    {

        private ApplicationDatabaseContext _databaseContext;
        public EmployeeController(ApplicationDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;

        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(IFormCollection keyValues)
        {
            if (keyValues == null)
            {
                var name = keyValues["name"];
            }

            _databaseContext.Employees.Add(new Entities.Employee()
            {
                Name = keyValues["name"],
                Department = keyValues["department"],
                JobTitle = keyValues["jobTitle"]
            });

            _databaseContext.SaveChanges();

            return Json(new { success=true, message="Employee Created Successfully"} );
        }

        [HttpGet]
        public IActionResult Table()
        {
           var employees =_databaseContext.Employees.ToList();

            return Json(new {success = true,list = employees});
        }
    }
}
