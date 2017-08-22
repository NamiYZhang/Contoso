using ContosoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoData
{
    public class InstructorRepository : IRepository<Instructor>
    {
        public void Create(Instructor obj)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetAll()
        {
            using (var db = new ContosoDBContext())
            {
                var instructors = db.Intructor.ToList();
                return instructors;
            }
        }

    }
}
