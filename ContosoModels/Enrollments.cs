using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoModels
{
    public class Enrollments
    {
        public int Id { get; set; }
        [ForeignKey("Courses")]
        public int CourseId { get; set; }
        public Courses Courses { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public string Grade { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

    }
}
