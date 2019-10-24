using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Models;

namespace Contoso.Servers
{
    public class PeopleService
    {
        PeopleRepository repo;
        public PeopleService()
        {
            repo = new PeopleRepository();
        }

        public IEnumerable<People> GetAllPeople()
        {
            return repo.GetAllPeople();
        }
        public void CreatePeople(People people)
        {
            repo.Create(people);
        }
        public People GetById(int id)
        {

            var result = repo.GetPeopleById(id);
            return result;
        }
        public People GetCoursebyname(string FirstName)
        {

            var result = repo.GetPeopleByName(FirstName);
            return result;

        }
    }
}
