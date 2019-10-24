using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;

namespace Contoso.Data
{
    public class DepartmentRepository : Repository<Departments>, IDepartmentRepository
    {

        public DepartmentRepository(ContosoDataDbContext context) : base(context)
        { 
        }

        public Departments GetDepartmentByName(string name)
        {
            var department = _dbContext.Departments.FirstOrDefault(d => d.Name == name);
            return department;
        }
    }
    public interface IDepartmentRepository : IRepository<Departments>
    {
        Departments GetDepartmentByName(string name);
       
    }
}
