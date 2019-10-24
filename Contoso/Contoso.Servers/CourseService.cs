using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Models;

namespace Contoso.Servers
{
    public class CourseService
    {
        CourseRepository repo;
        public CourseService()
        {
            repo = new CourseRepository();
        }

        public IEnumerable<Courses> GetAllCourse()
        {
            return repo.GetAllCourse();
        }
        public void CreateCourse(Courses course)
        {
            repo.Create(course);
        }
        public Courses GetById(int id)
        {

            var result = repo.GetCourseById(id);
            return result;
        }
        public Courses GetCoursebyname(string Name)
        {

            var result = repo.GetCourseByName(Name);
            return result;

        }
    }
}
