﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) => x + y;

            Console.WriteLine(add(3, 4));


            

            Action<int> write =  x => Console.WriteLine(x);

            write(square(add(3, 5)));

           var developers = new Employee[]
            {
                new Employee { Id = 1, Name = "Bobby"},
                new Employee { Id = 2, Name = "Julie"}
            };

            var sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex"}
            };

            var query = developers.Where(e => e.Name.Length == 5)
                                    .OrderByDescending(e => e.Name);


            var query2 = from developer in developers
                         where developer.Name.Length == 5
                         orderby developer.Name descending
                         select developer;


            foreach (var employee in query2)
            {
                Console.WriteLine(employee.Name);
            }

            //Console.WriteLine(developers.OrderBy(p => p.Name));

            //IEnumerator<Employee> enumerator = developers.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current.Name);
            //}
            //Console.ReadKey();
        }

        private static int Square(int arg)
        {
            throw new NotImplementedException();
        }

        private static bool NameStartsWithS(Employee employee)
        {
            return employee.Name.StartsWith("J");
        }
    }
}
