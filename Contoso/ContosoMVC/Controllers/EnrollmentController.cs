using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Servers;
using Contoso.Models;

namespace ContosoMVC.Controllers
{
    public class EnrollmentController : Controller
    {
        private EnrollmentService _enrollmentService;
        public EnrollmentController()
        {
            _enrollmentService = new EnrollmentService();
        }
        // GET: Enrollment
        public ActionResult Index()
        {
            var enrollments = _enrollmentService.GetAllEnrollment();
            // ViewData["Depts"] = departments;
            ViewBag.EnrollmentsCount = enrollments.Count();
            return View(enrollments);
        }
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Enrollments enrollment)
        {
            //get the data from the fromcollection and call services layer
            //save to database
            try
            {
                enrollment.CreatedDate = DateTime.Now;
                enrollment.UpdatedDate = DateTime.Now;

                _enrollmentService.CreateEnrollment(enrollment);

                return RedirectToAction("Index");

            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}