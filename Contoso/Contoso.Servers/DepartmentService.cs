using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Models;

namespace Contoso.Servers
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)//any class that implement that interface can be passed 
        {
            _departmentRepository = departmentRepository;
        }
        public void CreateDepartment()
        {
            throw new NotImplementedException();
        }

        public void CreateDepartment(Departments department)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Departments> GetAllDepartments()
        {
            return _departmentRepository.GetAll();
           
        }

        public Departments GetDepartmentById(int id)
        {
            return _departmentRepository.GetById(id);
        }

        public Departments GetDepartmentByName(string name)
        {
            return _departmentRepository.GetDepartmentByName(name);
        }

        public Departments GetDepartmentByName()
        {
            throw new NotImplementedException();
        }

        public int GetTotalDepartmentsCount()
        {
            throw new NotImplementedException();
        }
    }
    public class DepartmentService2 : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService2(IDepartmentRepository departmentRepository)//any class that implement that interface can be passed 
        {
            _departmentRepository = departmentRepository;
        }
        public void CreateDepartment()
        {
            throw new NotImplementedException();
        }

        public void CreateDepartment(Departments department)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Departments> GetAllDepartments()
        {
            return _departmentRepository.GetAll();

        }

        public Departments GetDepartmentById(int id)
        {
            return _departmentRepository.GetById(id);
        }

        public Departments GetDepartmentByName(string name)
        {
            return _departmentRepository.GetDepartmentByName(name);
        }

        public Departments GetDepartmentByName()
        {
            throw new NotImplementedException();
        }

        public int GetTotalDepartmentsCount()
        {
            throw new NotImplementedException();
        }
    }
    public interface IDepartmentService
    {
        IEnumerable<Departments> GetAllDepartments();
        int GetTotalDepartmentsCount();
        Departments GetDepartmentById(int id);
        Departments GetDepartmentByName();
        void CreateDepartment(Departments department);
    }
}





