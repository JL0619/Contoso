using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Models;
using Contoso.Servers;

namespace ContosoMVC.Controllers
{
    public class CourseController : Controller
    {
        private CourseService _courseService;
        public CourseController()
        {
            _courseService = new CourseService();
        }
        // GET: Course
        public ActionResult Index()
        {
            var courses= _courseService.GetAllCourse() ;
            // ViewData["Depts"] = departments;
            ViewBag.CourseCount = courses.Count();
            return View(courses);
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Courses course)
        {
            //get the data from the fromcollection and call services layer
            //save to database
            try
            {
                course.CreatedDate = DateTime.Now;
                course.UpdatedDate = DateTime.Now;

                _courseService.CreateCourse(course);

                return RedirectToAction("Index");

            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}