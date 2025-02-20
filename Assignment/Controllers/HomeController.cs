using Assignment.Models;
using Assignment.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;


namespace Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDepartmentService _departmentService;
        private readonly IEmployeeService _employeeService;
        public HomeController(IDepartmentService departmentService, ILogger<HomeController> logger, IEmployeeService employeeService)
        {
            _departmentService = departmentService;
            _logger = logger;
            _employeeService = employeeService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmployee()
        {
            var result = await _employeeService.GetAll();
            return Json(result);
        }


        public async Task<IActionResult> Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> AddEmployee(int id)
        {
            if (id==0)
            {
                AddEmployeeVM addEmployee = new AddEmployeeVM();
                addEmployee.Departments= await _departmentService.getalldepartment();
                return View(addEmployee);
            }
            else
            {
                AddEmployeeVM addEmployee = new AddEmployeeVM();
                addEmployee =await _employeeService.GetEmployeebyId(id);
                addEmployee.Departments = await _departmentService.getalldepartment();
                return View(addEmployee);
            }
            
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee(AddEmployeeVM addEmployeeVM)
        {
            bool status=await _employeeService.AddEmployee(addEmployeeVM);
            return RedirectToAction("Index");
        }
        
        public async Task<IActionResult> DeleteEmployee(int id)
        {
          
               bool status= await _employeeService.DeleteEmployee(id);
            if (status)
            {
                
            return RedirectToAction("Index");
            }else
            {
                return RedirectToAction("Error");
            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
