using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Models;

namespace Contoso.Servers
{
    public class EnrollmentService
    {
        EnrollmentRepository repo;
        public EnrollmentService()
        {
            repo = new EnrollmentRepository();
        }

        public IEnumerable<Enrollments> GetAllEnrollment()
        {
            return repo.GetAllEnrollment();
        }
        public void CreateEnrollment(Enrollments enrollment)
        {
            repo.Create(enrollment);
        }
        public Enrollments GetById(int id)
        {

            var result = repo.GetEnrollmentById(id);
            return result;
        }
        public Enrollments GetCoursebyname(string Name)
        {

            var result = repo.GetEnrollmentGrade(Name);
            return result;

        }

    }
}
