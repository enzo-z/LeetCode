using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank
{
    public class EmployeeManagement
    {
        public static void Start()
        {
            var employees = new List<Employee>()
            {
                new Employee() { FirstName = "Enzo", LastName = "Zamora", Company = "Bonde", Age = 30 },
                new Employee() { FirstName = "Klaus", LastName = "Kovalski", Company = "Bonde", Age = 21},
                new Employee() { FirstName = "Victor", LastName = "Polck", Company = "Bonde", Age = 28},
                new Employee() { FirstName = "Pedro", LastName = "Seco", Company = "Bonde", Age = 21},

                new Employee() { FirstName = "Cat", LastName = "Bertotti", Company = "Sonhe", Age = 18},
                new Employee() { FirstName = "Marcelle", LastName = "Guarisco", Company = "Sonhe", Age = 21},

                new Employee() { FirstName = "Luiz", LastName = "Miguel", Company = "Pentesters", Age = 23 },
                new Employee() { FirstName = "Wesley", LastName = "Ferreira", Company = "Pentesters", Age = 19 }
            };

            var mediaIdadeByCompany = employees.GroupBy(employee => employee.Company)
                .ToDictionary(x => x.Key, x => (int) x.Average(employee => employee.Age));

            foreach (var media in mediaIdadeByCompany)
            {
                Console.WriteLine($"{media.Key} tem a idade média de {media.Value} anos");
            }
            Console.WriteLine("");

            var quantidadeMembrosByCompany = employees.GroupBy(employee => employee.Company)
                .ToDictionary(x => x.Key, x => x.Count());

            foreach (var media in quantidadeMembrosByCompany)
            {
                Console.WriteLine($"{media.Key} possui {media.Value} membros");
            }
            Console.WriteLine("");
            
            var maiorIdadeByCompany = employees.GroupBy(employee => employee.Company)
                .ToDictionary(x => x.Key, x => x.Max(x => x.Age));

            foreach (var media in maiorIdadeByCompany)
            {
                Console.WriteLine($"A maior idade presente no {media.Key} é de {media.Value} anos");
            }

        }
    }

    public class Employee
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
        public string Company { get; set; } = null!;
    }
}
