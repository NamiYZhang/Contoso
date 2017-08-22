using ContosoData;
using ContosoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoService
{
    public class DepartmentService
    {
        public List<Departments> GetAllDepartments()
        {
            DepartmentRepository repository = new DepartmentRepository();
            var department = repository.GetAll();
            return department;
        }

        public void CreateDepartment(Departments department)
        {
            DepartmentRepository repository = new DepartmentRepository();
            repository.Create(department);
         
        }
        public Departments GetDepartmentById(int Id)
        {
            DepartmentRepository repository = new DepartmentRepository();
            return repository.GetById(Id);
        }

        public void UpdateDepartment(Departments department)
        {
            DepartmentRepository repository = new DepartmentRepository();
            repository.Update(department);
        }
    }
}
