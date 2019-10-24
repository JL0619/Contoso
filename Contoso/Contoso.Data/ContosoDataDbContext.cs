using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;

namespace Contoso.Data
{
    public class ContosoDataDbContext : DbContext
    {
        public ContosoDataDbContext() : base("Name=ContosoDataDbContext")
        {

        }
        public DbSet<People> People { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAssignments> OfficeAssignments { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Courses> Course { get; set; }
        public DbSet<Enrollments> Enrollment { get; set; }
    }
}
