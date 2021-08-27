using System;
using System.Linq;

namespace Practicequery
{
    class Program
    {
        static void Main()
        {
            // From w3resource LINQ

            //Q1
            //int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var nQurry =
            //    from num in number
            //    where (num % 2) == 0
            //    select num;

            //foreach (var num in nQurry)
            //{
            //    Console.WriteLine("{0} ", num);
            //}

            //Q2
            //int[] number = new int[] { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            //var nQuery =
            //    from num in number
            //    where (num > 0)
            //    where (num < 11)
            //    select num;
            //foreach(var item in nQuery)
            //{
            //    Console.WriteLine("{0} ", item);
            //}

            //Q3
            //int[] number = { 3, 9, 2, 8, 6, 5 };

            //var nQuerry =
            //    from num in number
            //    let multi = num * num
            //    where multi > 20
            //    select new { num, multi };
            //foreach (var item in nQuerry)
            //{
            //    Console.WriteLine(item);
            //}

            //Q4
            int[] number = { 5, 5, 5, 9, 9, 9, 9, 1 };

            var nQuery =
                from num in number
                group num by num into num2
                select num2;

            foreach(var item in nQuery)
            {
                Console.WriteLine("This " + item.Key + " apprear " + item.Count());
            }

        }
    }
}