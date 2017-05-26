using Lab03;
using System;
using System.Collections.Generic;

namespace LAB03
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var debs = new List<IPay>();

            debs.Add(new Invoice
            {
                Description = "Coke",
                Id = "1010",
                Price = 1.32M,
                Quantity = 48,
            });

            debs.Add(new Invoice
            {
                Description = "Milk",
                Id = "2020",
                Price = 1.22M,
                Quantity = 12,
            });

            debs.Add(new SalariedEmployee {
                FirstName = "Esperanza",
                Id = "1017825",
                LastName = "Gomez",
                Salary = 300000, 
            });

            decimal total = 0;
            foreach (var item in debs)
            {
                Console.WriteLine(item);
                total += item.GetAmountToPay();
            }

            Console.WriteLine("                                 ==================");
            Console.WriteLine("TOTAL..........................: {0,18:C2}", total);
            Console.WriteLine("Press any key to finish...");
            Console.ReadKey();
            Console.WriteLine("Hasta la vista baby");
        }
    }
}
