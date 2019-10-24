using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models
{
    [Table("Student")]
    public class Student:People
    {
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollments> Enrollment { get; set; }

    }
}
