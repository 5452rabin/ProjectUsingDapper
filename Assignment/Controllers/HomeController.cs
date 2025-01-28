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
        public async Task<IActionResult> Index(int departmentid, string searchname, int? page)
        {
            int pageSize = 6;
            int pageNumber = (page ?? 1); 
            IEnumerable<Department> departmentVMs = await _departmentService.getalldepartment();
            TempData["DepartmentsArray"] = JsonConvert.SerializeObject(departmentVMs);

            IEnumerable<AddEmployeeVM> addEmployeeVMs;

            if (departmentid != 0)
            {
                addEmployeeVMs = await _employeeService.GetEmployeeBydepartmentid(departmentid);
                ViewBag.selecteddepartmentid = departmentid;
                if (!string.IsNullOrEmpty(searchname))
                {
                    addEmployeeVMs = addEmployeeVMs.Where(emp => emp.Name.Contains(searchname, StringComparison.OrdinalIgnoreCase));
                    ViewBag.searchname = searchname;
                }
            }
            else
            {
                addEmployeeVMs = await _employeeService.GetAll();
                if (!string.IsNullOrEmpty(searchname))
                {
                    addEmployeeVMs = addEmployeeVMs.Where(emp => emp.Name.Contains(searchname, StringComparison.OrdinalIgnoreCase));
                    ViewBag.searchname = searchname;
                }
            }
            int totalRecords = addEmployeeVMs.Count();
            int totalPages = (int)Math.Ceiling((double)totalRecords / 10);

            var pagedEmployeeList = addEmployeeVMs
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            ViewBag.PageNumber = pageNumber;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalPages = totalPages;
            ViewBag.TotalRecords = totalRecords;

            return View(pagedEmployeeList);
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
