using ContosoService;
using ContosoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoMVC.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            CourseService cour = new CourseService();
            var courses = cour.GetAllCourses();
            return View(courses);
        }

        public ActionResult GetAllCourses()
        {

            CourseService cour = new CourseService();
            var courses = cour.GetAllCourses();
            return View(courses);
        }

        public ActionResult Create()
        {
 
            return View();
        }

        [HttpPost]
        public ActionResult Create(Courses course)
        {
            CourseService cour = new CourseService();
            cour.CreateCourse(course);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            CourseService cour = new CourseService();
            var course = cour.GetCourseById(Id);
   
            return View(course);
        }
        [HttpPost]
        public ActionResult Edit(Courses course)
        {
            CourseService cour = new CourseService();
            cour.UpdateCourse(course);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int Id)
        {
            CourseService cour = new CourseService();
            var course = cour.GetCourseById(Id);
            return View(course);
        }


    }
}