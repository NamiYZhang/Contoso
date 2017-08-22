using ContosoModels;
using ContosoService;
using ContosoUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoMVC.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            PersonService person = new PersonService();
            var people = person.GetAllPeople();
            return View(people);
        }
        public ActionResult GetAllPeople()
        {

            PersonService person = new PersonService();
            var people = person.GetAllPeople();
            return View(people);
        }

        public ActionResult Create()
        {
            //var list = Utility.GetAllStates();
            //ViewBag.State = new SelectList(list, "StateName", "Value");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {

            PersonService per = new PersonService();
            per.CreatePerson(person);
            return RedirectToAction("GetAllPeople");
        }

        public ActionResult Edit(int Id)
        {
            PersonService per = new PersonService();
            var person = per.GetPersonById(Id);
            //var list = Utility.GetAllStates();
            //ViewBag.State = new SelectList(list, "StateName", "Value");
            return View(person);
        }
        [HttpPost]
        public ActionResult Edit(Person person)
        {
            PersonService dep = new PersonService();
            dep.UpdatePerson(person);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int Id)
        {
            PersonService dep = new PersonService();
            var person = dep.GetPersonById(Id);
            return View(person);
        }
    }
}