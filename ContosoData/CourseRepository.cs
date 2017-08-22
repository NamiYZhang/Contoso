using ContosoModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoData
{
    public class CourseRepository: IRepository<Courses>
    {
        public void Create(Courses course)
        {
            using (var db = new ContosoDBContext())
            {
                db.Courses.Add(course);
                db.SaveChanges(); 
            } 
        }

        public List<Courses> GetAll()
        {
            using (var db = new ContosoDBContext())
            {
                var courses = db.Courses.ToList();
                return courses;
            }
        }

        public Courses GetById(int id)
        {
            using (var db = new ContosoDBContext())
            {
                var course = db.Courses.Where(d => d.Id == id).FirstOrDefault();
                return course;
            }
        }

        public void Update(Courses course)
        {
            using (var db = new ContosoDBContext())
            {
                db.Courses.Attach(course);
                db.Entry(course).State = EntityState.Modified;
                db.SaveChanges();

            }
        }

        public Courses Details(int id)
        {
            using (var db = new ContosoDBContext())
            {
                var course = db.Courses.Where(d => d.Id == id).FirstOrDefault();
                return course;
            }
        }
    }
}
