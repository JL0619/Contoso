using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;

namespace Contoso.Data
{
    public class CourseRepository
    {
        public Courses GetCourseById(int id)
        {
            using (var db = new ContosoDataDbContext())
            {
                var result = db.Course.Where(d => d.Id == id).FirstOrDefault();
                return result;
            }

        }
        public IEnumerable<Courses> GetAllCourse()
        {
            using (var db = new ContosoDataDbContext())
            {
                return db.Course.ToList();
            }
        }
        public Courses GetCourseByName(string Title)
        {
            using (var db = new ContosoDataDbContext())
            {
                return db.Course.Where(d => d.Title == Title).SingleOrDefault();
            }
        }
        public void Create(Courses course)
        {
            using (var db = new ContosoDataDbContext())
            {
                db.Course.Add(course);
                db.SaveChanges();
            }

        }
    }
}
