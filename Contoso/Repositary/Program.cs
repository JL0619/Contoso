using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Models;
using Contoso.Servers;

namespace Repositary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Repository repository = new Repository();
            //var result = repository.GetDepartmentById(9);
            //Console.WriteLine(result.Name);

            //var DepartmentName = repository.GetAllDepartment();
            //foreach (var item in DepartmentName)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //var Departmentname = repository.GetDepartmentByName("Business");
            //Console.WriteLine(Departmentname);

            //var HighestBudget = repository.GetHighestBudgetDepartment();
            //Console.WriteLine(HighestBudget);
            //Console.ReadLine();
            DepartmentService DP;
            DP = new DepartmentService();
            Console.WriteLine(DP);
            Console.ReadLine();
        }

    }
}
