using HrApplication.Database;
using HrApplication.Entities;
using HrApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HrApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDatabaseContext _databaseContext;

        public EmployeeController(ApplicationDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Dashboard(int employeeId)
        {
            var employee = _databaseContext.Employees.FirstOrDefault(e => e.Id == employeeId);
            if (employee == null)
            {
                return NotFound();
            }

            var employeeViewModel = new EmployeeVM
            {
                Id = employee.Id,
                Name = employee.Name,
                Department = employee.Department,
                JobTitle = employee.JobTitle,
            };

            return View(employeeViewModel);
        }

        [HttpPost]
        public IActionResult Save(EmployeeVM employeeVM)
        {
            string statusMessage;

            if (employeeVM.Id != 0)
            {
                Employee employee = _databaseContext.Employees.Find(employeeVM.Id);

                if (employee != null)
                {
                    employee.Name = employeeVM.Name;
                    employee.Department = employeeVM.Department;
                    employee.JobTitle = employeeVM.JobTitle;

                    _databaseContext.Employees.Update(employee);
                    int updateStatus = _databaseContext.SaveChanges();

                    if (updateStatus == 0)
                    {
                        statusMessage = "Failed to update employee.";
                        TempData["StatusMessage"] = statusMessage;
                        return RedirectToAction(nameof(Index));
                    }

                    statusMessage = "Employee updated successfully";
                }
                else
                {
                    statusMessage = "Employee not found.";
                    TempData["StatusMessage"] = statusMessage;
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                _databaseContext.Employees.Add(new Employee
                {
                    Name = employeeVM.Name,
                    Department = employeeVM.Department,
                    JobTitle = employeeVM.JobTitle
                });

                int status = _databaseContext.SaveChanges();

                if (status == 0)
                {
                    statusMessage = "Failed to save changes. Please check your entries.";
                    TempData["StatusMessage"] = statusMessage;
                    return RedirectToAction(nameof(Index));
                }

                statusMessage = "Employee Created Successfully";
            }

            TempData["StatusMessage"] = statusMessage;
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Table()
        {
            List<Employee> employees = _databaseContext.Employees.ToList();

            return Json(new { success = true, list = employees });
        }

        [HttpGet]
        public IActionResult Create(int id = 0)
        {
            EmployeeVM employeeVM;

            if (id != 0)
            {
                Employee localEmployee = _databaseContext.Employees.Find(id);

                if (localEmployee != null)
                {
                    employeeVM = new EmployeeVM
                    {
                        Id = localEmployee.Id,
                        Name = localEmployee.Name,
                        Department = localEmployee.Department,
                        JobTitle = localEmployee.JobTitle
                    };
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                employeeVM = new EmployeeVM();
            }

            return View("_Create", employeeVM);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Employee employee = _databaseContext.Employees.Find(id);

            if (employee == null)
            {
                return Json(new { success = false, message = "Employee not found." });
            }

            _databaseContext.Employees.Remove(employee);
            int status = _databaseContext.SaveChanges();

            if (status == 0)
            {
                return Json(new { success = false, message = "Failed to delete employee." });
            }

            return Json(new { success = true, message = "Employee deleted successfully." });
        }
    }
}
