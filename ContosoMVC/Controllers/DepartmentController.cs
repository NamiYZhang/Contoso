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
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        //public DepartmentController()
        //{
        //    _departmentService = new DepartmentService();
        //}
        //public DepartmentController()
        //{
        //    int i = 0;  
        //    int x = 1;
        //    int z = x / i;
        //}

        //GET: Department
        public ActionResult Index()
        {
            //DepartmentService dep = new DepartmentService();
            var department = _departmentService.GetAllDepartments();
            return View(department);
        }

        public ActionResult GetAllDepartment()
        {

            //DepartmentService dep = new DepartmentService();
            var department = _departmentService.GetAllDepartments();
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
                //DepartmentService dep = new DepartmentService();
                _departmentService.CreateDepartment(department);
                return RedirectToAction("GetAllDepartment");
            }
            else
            {
                return View(department);
            }
   
        }

        public ActionResult Edit(int Id)
        {
           
              //DepartmentService dep = new DepartmentService();
              var department = _departmentService.GetDepartmentById(Id);

              return View(department);
            
        }
        [HttpPost]
        public ActionResult Edit(Departments department)
        {
            if (ModelState.IsValid)
            {
                //DepartmentService dep = new DepartmentService();
                _departmentService.UpdateDepartment(department);
            return RedirectToAction("Index");
            }
            else
            {
                return View(department);
            }
        }

        public ActionResult Details(int Id)
        {
           // DepartmentService dep = new DepartmentService();
            var department = _departmentService.GetDepartmentById(Id);
            return View(department);
        }
        public ActionResult CreateDepartmentCourse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDepartmentCourse(DepartmentCourseViewModel model)
        {

            if (ModelState.IsValid)
            {
                //DepartmentService departmentService = new DepartmentService();
                Departments dept = new Departments();
                dept.Name = model.DepartmentName;
                dept.Budget = Convert.ToDouble(model.DepartmentBudget);
                dept.StartDate = model.StartDate;
                dept.CreatedDate = model.CreatedDate;
                dept.CreatedBy = model.CreatedBy;
                dept.UpdatedDate = model.UpdatedDate;
                dept.UpdatedBy = model.UpdatedBy;
                dept.InstructorId = model.InstructorId;
                _departmentService.CreateDepartment(dept);

                CourseService courseService = new CourseService();
                Courses course = new Courses();
                course.Title = model.CourseName;
                course.DepartmentId = model.DepartmentId;
                course.CreatedDate = model.CreatedDate;
                course.CreatedBy = model.CreatedBy;
                course.UpdatedDate = model.UpdatedDate;
                course.UpdatedBy = model.UpdatedBy;


                courseService.CreateCourse(course);
                return RedirectToAction("Index");
                //return View(model);
            }
            else
            {
                return View(model);
            }
        }
    } 

   }