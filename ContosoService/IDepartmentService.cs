using ContosoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoService
{
    public interface IDepartmentService
    {
        List<Departments> GetAllDepartments();
        void CreateDepartment(Departments department);
        Departments GetDepartmentById(int Id);
        void UpdateDepartment(Departments department);

    }
}
