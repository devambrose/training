using HrApplication.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HrApplication.Controllers
{
    public class AllowanceController :Controller
    {

        private ApplicationDatabaseContext _databaseContext;

        public AllowanceController(ApplicationDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }


        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Save(IFormCollection keyvalues)
        {

            if (keyvalues == null)
            {
                var name = keyvalues["name"];
            }


            _databaseContext.Allowances.Add(new Entities.Allowance()
            {
                Name = keyvalues["name"],
                Description = keyvalues["description"],
                Amount = Double.Parse(keyvalues["amount"])    
            });

            _databaseContext.SaveChanges();

            return Json(new { success=true,message="Allowance Created Successfully"});
        }

        [HttpGet]
        public IActionResult Table()
        {

            var allowances=  _databaseContext.Allowances.ToList();

            return Json(new { success=true,list=allowances });
        }


    }
}
