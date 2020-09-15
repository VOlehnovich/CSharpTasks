using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Напишите программу ввода с клавиатуры трёх произвольных чисел X,Y,Z.
    Программа должна найти наименьшее число из введённых, и вывести его на экран.*/
    class Task2
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число Z: ");
            int z = Convert.ToInt32(Console.ReadLine());

            int minValue = x;

            if (minValue < y && minValue < z)
            {
                Console.WriteLine($"Найменьшее число: {x}");
            }
            else if (minValue > y && y < z)
            {
                Console.WriteLine($"Наименьшее число: {y}");
            }
            else
            {
                Console.WriteLine($"Наименьшее число: {z}");
            }
            Console.ReadKey();


        }
    }
}
