using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*Проверить, поместится ли на диске компьютера музыкальная композиция,
    которая длится m минут и n секунд, если свободное дисковое пространство
    6 мегабайт, а для записи одной секунды звука необходимо 16 килобайт.*/
    class Task4
    {
        static void Main(string[] args)
        {
            Console.Write("Введите m в минутах: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите n в секундах: ");
            int n = int.Parse(Console.ReadLine());

            int durationSongSec = 60 * m + n;
            int durationSongKByte = durationSongSec * 16;

            if (durationSongKByte <= 6 * 1024)
            {
                Console.WriteLine("Музыкальная композиция записана успешно");
            }
            else
            {
                Console.WriteLine($"Недостаточно свободного места. Превышение на {durationSongKByte-6 * 1024} килобайт");
            }
            Console.ReadKey();
        }
    }
}
