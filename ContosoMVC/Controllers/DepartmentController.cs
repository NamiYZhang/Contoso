using ContosoModels;
using ContosoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoMVC.Controllers
{
    public class DepartmentController : Controller
    {
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
            //string Name = form["Name"];
            //decimal Budget = Convert.ToDecimal(form["Budget"]);
            //DateTime StartDate=form["StartDate"]
            //int InstructorId = Convert.ToInt32(form["InstructorId"]);
            //DateTime CreatedDate = form["CreatedDate"]
            //string CreatedBy = form["CreatedBy"];
            //DateTime UpdatedDate = form["UpdatedDate"]
            //string UpdatedBy = form["UpdatedBy"];
            DepartmentService dep = new DepartmentService();
            dep.CreateDepartment(department);
            return RedirectToAction("GetAllDepartment");
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

    } 

   }