using ContosoData;
using ContosoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoService
{
    public class CourseService
    {
        public List<Courses> GetAllCourses()
        {
            CourseRepository repository = new CourseRepository();
            var course = repository.GetAll();
            return course;
        }

        public void CreateCourse(Courses course)
        {
            CourseRepository repository = new CourseRepository();
            repository.Create(course);

        }
        public Courses GetCourseById(int Id)
        {
            CourseRepository repository = new CourseRepository();
            return repository.GetById(Id);
        }

        public void UpdateCourse(Courses course)
        {
            CourseRepository repository = new CourseRepository();
            repository.Update(course);
        }

    }
}
