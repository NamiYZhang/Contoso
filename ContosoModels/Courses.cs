using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoModels
{
    public class Courses
    {

        public int Id { get; set; }
        public ICollection<Enrollments> Enrollments { get; set; }
        public ICollection<Instructor> Instructor { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required(ErrorMessage = "Please enter a valid Course Name")]
        public string Title { get; set; }

        public int Credit { get; set; }
        [ForeignKey("Departments")]
        public int DepartmentId { get; set; }
        public Departments Departments { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        


    }
}
