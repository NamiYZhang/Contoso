using ContosoModels;
using ContosoData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoService
{
    public class InstructorService
    {
        public List<Instructor> GetAllInstructors()
        {
            InstructorRepository repository = new InstructorRepository();
            var instr = repository.GetAll();
            return instr;
        }
    }
}
