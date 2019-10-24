using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;

namespace Contoso.Data
{
    public class EnrollmentRepository
    {
        public Enrollments GetEnrollmentById(int id)
        {
            using (var db = new ContosoDataDbContext())
            {
                var result = db.Enrollment.Where(d => d.Id == id).FirstOrDefault();
                return result;
            }

        }
        public IEnumerable<Enrollments> GetAllEnrollment()
        {
            using (var db = new ContosoDataDbContext())
            {
                return db.Enrollment.ToList();
            }
        }
        public Enrollments GetEnrollmentGrade(string Grade)
        {
            using (var db = new ContosoDataDbContext())
            {
                return db.Enrollment.Where(d => d.Grade== Grade).SingleOrDefault();
            }
        }
        public void Create(Enrollments enrollment)
        {
            using (var db = new ContosoDataDbContext())
            {
                db.Enrollment.Add(enrollment);
                db.SaveChanges();
            }

        }
    }
}
