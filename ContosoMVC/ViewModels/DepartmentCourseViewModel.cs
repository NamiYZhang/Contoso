using ContosoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoMVC.ViewModels
{
    public class DepartmentCourseViewModel
    {
        public int CourseId { get; set; }
        public int DepartmentId { get; set; }
        public string CourseName { get; set; }
        public string DepartmentName { get; set; }
        public decimal DepartmentBudget { get; set; }
        public int InstructorId { get; set; }
        public int Credit { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; } 
    }
}