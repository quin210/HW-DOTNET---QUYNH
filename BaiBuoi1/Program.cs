using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiBuoi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b; 
            Console.WriteLine("Enter 2 numbers: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum of them is {a + b}");

            Console.WriteLine("------------------------");

            int n;
            Console.WriteLine("Enter n: ");
            n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                if (i % 2 == 0) sum += i;
            }
            Console.WriteLine($"Sum is {sum}");    
            Console.ReadKey();
        }

    }
}
