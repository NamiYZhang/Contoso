using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoModels
{
    public class Departments
    {
        public int Id { get; set; }
        [DisplayName("Department Name")]
        public string Name { get; set; }
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
