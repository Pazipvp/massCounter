using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //int S = int.Parse(Console.ReadLine()); ;



            Console.WriteLine(IsValid(int.Parse(Console.ReadLine())));


            //for(int i = 1; sum < S; i++)
            //{
            //    sum += i;

            //    if (sum == S)
            //        Console.WriteLine("Треугольное число");
            //    else
            //        Console.WriteLine("Не тругоульное число");
            //}


            Console.ReadKey();
        }
        private static bool IsValid (int number)
        {
            double k = (-1.0 + Math.Sqrt(1 + 8 * number)) / 2;

            if (Math.Ceiling(k) == Math.Floor(k))
                return true;
            else 
                return false;
        }
    }
}
