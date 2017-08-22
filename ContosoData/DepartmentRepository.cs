using ContosoModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoData
{
    public class DepartmentRepository : IRepository<Departments>
    {
        public void Create(Departments department)
        {
            using (var db = new ContosoDBContext())
            {
                db.Departments.Add(department);
                db.SaveChanges();
            }
        }

        public List<Departments> GetAll()
        {
            using (var db = new ContosoDBContext())
            {
                var departments = db.Departments.ToList();
                return departments;
            }
        }

        public Departments GetById(int id)
        {
            using (var db = new ContosoDBContext())
            {
                var department = db.Departments.Where(d=>d.Id==id).FirstOrDefault();
                return department;
            }
        }

        public void Update(Departments department)
        {
            using (var db = new ContosoDBContext())
            {
                db.Departments.Attach(department);
                db.Entry(department).State = EntityState.Modified;
                db.SaveChanges();
                
            }
        }

        public Departments Details(int id)
        {
            using (var db = new ContosoDBContext())
            {
                var department = db.Departments.Where(d => d.Id == id).FirstOrDefault();
                return department;
            }
        }

   
    }
}




  