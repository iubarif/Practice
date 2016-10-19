using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee { Id=101, Name="John"},
                new Employee { Id=102, Name="Mark"},
                new Employee { Id=103, Name="Alan"},
                new Employee { Id=104, Name="Don"}
            };


            //var employee = listEmployees.Find(delegate (Employees emp) {
            //    return emp.Id == 102;
            //});

            var employee = listEmployees.Find(Emp => Emp.Id == 102);
            Console.WriteLine("ID = {0}, Name = {1}", employee.Id, employee.Name);
            Console.ReadLine();
        }
        
    }
}

