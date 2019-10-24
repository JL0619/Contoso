using System;
using Contoso.Servers;
using Contoso.Data;
using Contoso.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;//MS test by Miscrosoft(Nunit,Xunit),popular unit test framework
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Moq;

namespace ContosoMVC.Tests.Srvices
{
    [TestClass]
    public class DepartmentServiceTest
    {
        private IDepartmentService _departmentService;
        private Mock<IDepartmentRepository> _mockDepartmentRepository;
        private List<Departments> _departments;



        [TestInitialize]
        public void initilize()
        {
            _mockDepartmentRepository = new Mock<IDepartmentRepository>();
            _departmentService = new DepartmentService(_mockDepartmentRepository.Object);
            //initilaize the fake data
            _departments = new List<Departments>
                {
                    new Departments
                    {
                        Id =1,
                        Name = "CS",
                        Budget = 4000,
                        StartDate = DateTime.Now
                    },
                    new Departments
                    {
                        Id =2,
                        Name = "MIS",
                        Budget = 5000,
                        StartDate = DateTime.Now
                    },
                    new Departments
                    {
                        Id =3,
                        Name = "BIA",
                        Budget = 6000,
                        StartDate = DateTime.Now
                    },
                    new Departments
                    {
                        Id =4,
                        Name = "EE",
                        Budget = 3000,
                        StartDate = DateTime.Now
                    },

                };

            _mockDepartmentRepository.Setup(d => d.GetAll()).Returns(_departments);
            _mockDepartmentRepository.Setup(d => d.GetById(It.IsAny<int>())).Returns((int s) => _departments.First(x => x.Id == s));
        }
        [TestMethod]
        public void CheckDepartmentCountFromFakeData()
        {
            //_departmentService = new DepartmentService(new MockDepartmentRepository());

            var departments = _departmentService.GetAllDepartments();
            Assert.IsNotNull(departments);
            Assert.AreEqual(4,departments.Count());
        }

        [TestMethod]
        public void CheckDepartmentNameFromFakeData()
        {
            var departments = _departmentService.GetDepartmentById(3);
            Assert.AreEqual("BIA", departments.Name);
        }
        //public class MockDepartmentRepository : IDepartmentRepository
        //{
        //    public void Add(Departments entity)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void Delete(Departments entity)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void Delete(Expression<Func<Departments, bool>> where)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public Departments Get(Expression<Func<Departments, bool>> where)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public IEnumerable<Departments> GetAll()
        //    {
        //        var departments = new List<Departments>
        //        {
        //            new Departments
        //            {
        //                Id =1,
        //                Name = "CS",
        //                Budget = 4000,
        //                StartDate = DateTime.Now
        //            },
        //            new Departments
        //            {
        //                Id =2,
        //                Name = "MIS",
        //                Budget = 5000,
        //                StartDate = DateTime.Now
        //            },
        //            new Departments
        //            {
        //                Id =3,
        //                Name = "BIA",
        //                Budget = 6000,
        //                StartDate = DateTime.Now
        //            },
        //            new Departments
        //            {
        //                Id =4,
        //                Name = "EE",
        //                Budget = 3000,
        //                StartDate = DateTime.Now
        //            },
               
        //        };
        //        return departments;
        //    }

        //    public Departments GetById(int id)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public int GetCount(Expression<Func<Departments, bool>> filter = null)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public Departments GetDepartmentByName(string name)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public IEnumerable<Departments> GetMany(Expression<Func<Departments, bool>> where)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void SaveChanges()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void Update(Departments entity)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}
