using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoModels
{
    public class Departments
    {
        public int Id { get; set; }
        [DisplayName("Department Name")]
        [Required(ErrorMessage ="Please enter Valid Department Name!!!")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter budget for department")]
        public double Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public ICollection<Courses> Courses { get; set; }
    }
}
