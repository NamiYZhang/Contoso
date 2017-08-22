using ContosoModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoData
{
    class ContosoDBContext:DbContext
    {
        public ContosoDBContext() : base("name=ContosoDB")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Enrollments> Enrollments { get; set; }
        public DbSet<Instructor> Intructor { get; set; }
        public DbSet<OfficeAssignments> OfficeAssignments { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Student> Student { get; set; }

    }
}

