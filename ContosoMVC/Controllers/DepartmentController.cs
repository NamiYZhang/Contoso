using ContosoModels;
using ContosoMVC.Filters;
using ContosoMVC.ViewModels;
using ContosoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoMVC.Controllers
{
    [HandleError]
    //[LogActionFilter]
    public class DepartmentController : Controller
    {
        //public DepartmentController()
        //{
        //    int i = 0;
        //    int x = 1;
        //    int z = x / i;
        //}
        // GET: Department
        public ActionResult Index()
        {

            DepartmentService dep = new DepartmentService();
            var department = dep.GetAllDepartments();
            return View(department);
        }

        public ActionResult GetAllDepartment()
        {

            DepartmentService dep = new DepartmentService();
            var department = dep.GetAllDepartments();
            return View(department);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Departments department)
        {
            if (ModelState.IsValid)
            {
                DepartmentService dep = new DepartmentService();
                dep.CreateDepartment(department);
                return RedirectToAction("GetAllDepartment");
            }
            else
            {
                return View(department);
            }
   
        }

        public ActionResult Edit(int Id)
        {
            DepartmentService dep = new DepartmentService();
            var department = dep.GetDepartmentById(Id);

            return View(department);
        }
        [HttpPost]
        public ActionResult Edit(Departments department)
        {
            DepartmentService dep = new DepartmentService();
            dep.UpdateDepartment(department);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int Id)
        {
            DepartmentService dep = new DepartmentService();
            var department = dep.GetDepartmentById(Id);
            return View(department);
        }
        public ActionResult CreateDepartmentCourse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDepartmentCourse(DepartmentCourseViewModel model)
        {
            DepartmentService departmentService = new DepartmentService();
            Departments dept = new Departments();
            dept.Name = model.DepartmentName;
            dept.Budget = Convert.ToDouble(model.DepartmentBudget);
            departmentService.CreateDepartment(dept);

            CourseService courseService = new CourseService();
            Courses course = new Courses();
            course.Title = model.CourseName;
            courseService.CreateCourse(course);

            return View();
        }
    } 

   }