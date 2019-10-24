using System;
using System.Linq;
using System.Web.Mvc;
using Contoso.Servers;
using Contoso.Models;
using ContosoMVC.Filters;

namespace ContosoMVC.Controllers
{
    [ContosoExceptionFilter]
    public class DepartmentController : Controller//is a mvc base class 
    {
        private readonly IDepartmentService _departmentService;
        //private DepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        // GET: Department
        
        public ActionResult Index()//action methods usually returns tyoe would be actionresult
        {
            
            var departments = _departmentService.GetAllDepartments();
            // ViewData["Depts"] = departments;
            ViewBag.DepartmentsCount = departments.Count();
            return View(departments);

        }
        //public ActionResult GetHighestBudgetDepartment()//action methods usually returns tyoe would be actionresult
        //{
        //  //  var highestbudgetdepartments = _departmentService.GetHighestBudgetDepartment();
        //    //ViewBag.HighestBudgetDepartment = highestbudgetdepartments;
        //   // return View(highestbudgetdepartments);
        //}

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Departments department)
        {
            //get the data from the fromcollection and call services layer
            //save to database
            try
            {
                //var departmentname = form["departmentname"];
                //var budget = form["budget"];
                //var startdate = form["startdate"];

                //Departments department = new Departments();
                //department.Name = departmentname;
                //department.Budget = budget;
                //department.StartDate = startdate;
                department.InstructorId = 2;
                department.CreatedDate = DateTime.Now;
                department.UpdatedDate = DateTime.Now;

                _departmentService.CreateDepartment(department);

                return RedirectToAction("Index");

            }
            catch (Exception)
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var departments = _departmentService.GetDepartmentById(id);
            return View(departments);
        }

        [HttpPost]
        public ActionResult Edit(Departments department)
        {
          //  _departmentService.EditDepartment(department);
            return RedirectToAction("Index");
        }


        //public ActionResult GetDepartmentById()//action methods usually returns tyoe would be actionresult
        //{
        //    int id = Convert.ToInt32(Request.Form["DepartmentId"]);
        //    var departmentById = _departmentService.GetById(id);
        //    //ViewBag.HighestBudgetDepartment = highestbudgetdepartments;
        //    return View(departmentById);
        //}

        //public ActionResult GetDepartmentByName()//action methods usually returns tyoe would be actionresult
        //{
        //    string name = Request.Form["Name"];
        //    var departmentByName = _departmentService.GetDepartmentbyname(name);
        //    //ViewBag.HighestBudgetDepartment = highestbudgetdepartments;
        //    return View(departmentByName);
        //}

      
        //public ActionResult GetName()
        //{
        //    return View();
        //}
    }
}