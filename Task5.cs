using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    //Для любого целого числа N>7 найти все такие пары целых чисел x и y, что 3x+5y=N.
    class Task5
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Введите число N: ");
            int n = int.Parse(Console.ReadLine());
            int k = n % 5;
            for (int y = 0; y < k; y++)
            {
                x = (n - 5 * y) % 3;
                if (x % 2 == 0)
                {
                    Console.WriteLine($"x: {x} и y: {y}");
                }
            }
            Console.ReadKey();
        }
    }
}
