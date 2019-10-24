using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;

namespace Contoso.Data
{
    public class PeopleRepository
    {
        public People GetPeopleById(int id)
        {
            using (var db = new ContosoDataDbContext())
            {
                var result = db.People.Where(d => d.Id == id).FirstOrDefault();
                return result;
            }

        }
        public IEnumerable<People> GetAllPeople()
        {
            using (var db = new ContosoDataDbContext())
            {
                return db.People.ToList();
            }
        }
        public People GetPeopleByName(string FirstName)
        {
            using (var db = new ContosoDataDbContext())
            {
                return db.People.Where(d => d.FirstName == FirstName).SingleOrDefault();
            }
        }
        public void Create(People people)
        {
            using (var db = new ContosoDataDbContext())
            {
                db.People.Add(people);
                db.SaveChanges();
            }
        }
    }
}
