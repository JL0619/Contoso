using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Models;
using Contoso.Servers;

namespace ContosoMVC.Controllers
{
    public class PeopleController : Controller
    {
        private PeopleService _peopleservice;
        // GET: People
        public PeopleController()
        {
            _peopleservice = new PeopleService();
        }
        public ActionResult Index()
        {
            var people = _peopleservice.GetAllPeople();
            // ViewData["Depts"] = departments;
            ViewBag.PeopleCount = people.Count();
            return View(people);
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(People people)
        {
            //get the data from the fromcollection and call services layer
            //save to database
            try
            {
                people.CreatedDate = DateTime.Now;
                people.UpdatedDate = DateTime.Now;

                _peopleservice.CreatePeople(people);

                return RedirectToAction("Index");

            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}