using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*Длина прямоугольного участка земли равна X метров, а ширина равна Y метров.
    Напишите программу вычисления количества досок для забора на заданном участке,
    если ширина доски равна 10 сантиметров.*/
    class Task3
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну участка в сантиментрах: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите ширину участка в сантиментрах: ");
            int y = int.Parse(Console.ReadLine());

            int perimeter = 2 * (x + y);
            int widthPlank = 10;
            int numberPlanks = perimeter / widthPlank;

            Console.WriteLine($"Необходимо max {numberPlanks} досок");
            Console.ReadKey();
        }
    }
}
