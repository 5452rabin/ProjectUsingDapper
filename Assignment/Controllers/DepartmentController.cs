using Assignment.Models;
using Assignment.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            DepartmentVM departmentvm = new();
            departmentvm.Departments=await _departmentService.getalldepartment();
            return View(departmentvm);
        }
        [HttpPost]
        public async Task<IActionResult> AddDepartment(DepartmentVM department)
        {
            bool status=await _departmentService.AddDepartment(department);
            ViewBag.Status = status;
            return RedirectToAction("Index");
        }
    }
}
