using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /*Напишите программу ввода трёх произвольных чисел X, Y и Z с клавиатуры.
    Если X больше Z, то вывести на экран сумму X и Y, иначе вывести на экран значение Z.*/
    class Task1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число Z: ");
            int z = Convert.ToInt32(Console.ReadLine());

            if (x > z)
            {
                int result = x + y;
                Console.WriteLine($"X больше Z, значит сумма X и Y равна: {result}");
            }
            else
            {
                Console.WriteLine($"X меньше Z, значит Z: {z}");
            }
            Console.ReadKey();
        }
    }
}
