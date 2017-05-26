using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class PruebaEmpleado
    {
        static void Main(string[] args)
        {
            var employess = new List<Employee>();
            employess.Add(new Employee
            {
                BornDate = new Date(1954, 13, 43),
                FirstName = "Celia",
                HireDate = new Date(2000, 2, 29),
                LastName = "Cruz"
            });
            employess.Add(new Employee
            {
                BornDate = new Date(1980, 6, 21),
                FirstName = "Carlos",
                HireDate = new Date(1980, 2, 29),
                LastName = "Garcia"
            });

            foreach (var employee in employess)
            {
                Console.WriteLine(employee);
            }

            Console.ReadKey();

        }
    }
}
