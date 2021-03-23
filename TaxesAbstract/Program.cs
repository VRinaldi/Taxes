using System;
using TaxesAbstract.Entities;
using TaxesAbstract.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;

namespace TaxesAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> list = new List<Payer>();
            Console.Write("Enter the number of payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? " );
                Person person = Enum.Parse<Person>(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if (person == 0)
                {
                    Console.Write("Health Expeditures: ");
                    double expeditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(expeditures, person, name, anualIncome));
                } else 
                {
                    Console.Write("Number of Employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(employees, person, name, anualIncome));
                }

            }
            Console.WriteLine();
            Console.WriteLine("Taxes:");
            foreach(Payer pay in list)
            {
                Console.WriteLine(pay.Name + ": $" + pay.Taxes().ToString("F2", CultureInfo.InvariantCulture));
            }

            double sum = 0;
            foreach (Payer pay in list)
            {
                sum += pay.Taxes();
            }
            Console.WriteLine("Total : $" + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
