using System;
using System.Collections.Generic;

namespace Lab02
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>();

            var emp1 = new SalariedEmployee("1010", "Celia", "Cruz", 3500000);
            employees.Add(emp1);
            var emp2 = new SalariedEmployee("2020", "Hector", "Lavoe", 4500000);
            employees.Add(emp2);
            var emp3 = new CommissionEmployee("3030", "Natalia", "Paris", 0.023, 250000000);
            employees.Add(emp3);
            var emp4 = new CommissionEmployee("4040", "Esperanza", "Gomez", 0.027, 340000000);
            employees.Add(emp4);
            var emp5 = new HourlyEmployee("5050", "Rolando", "Laserie", 167, 13500);
            employees.Add(emp5);
            var emp6 = new HourlyEmployee("6060", "Liv", "Taylor", 245, 45000);
            employees.Add(emp6);
            var emp7 = new CommisionedBaseEmployee("7070", "Tatiana", "De Los Rios", 0.012, 32000000, 670000);
            employees.Add(emp7);

            decimal paysheet = 0;
            foreach (var employee in employees)
            {
                System.Console.WriteLine(employee);
                paysheet += employee.CalculateSalary();
            }

            System.Console.WriteLine("                                ==================");
            Console.WriteLine("Paysheet......................: {0,18:C2}", paysheet);
            Console.WriteLine("Press any key to finish...");
            Console.ReadKey();
            Console.WriteLine("Hasta la vista baby");
        }
    }
}
