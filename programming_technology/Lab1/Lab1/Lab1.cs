using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Lab1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Часть 1");
            Console.WriteLine("Лабораторная работа №1");
            Console.WriteLine("Выполнил: Абдувоитов Мухаммадкодир");
            Console.WriteLine("Группа: ИНС-б-о-19-1(2); Специальность: 09.03.02");
            Console.WriteLine("Дата рождения: 2001.08.06");
            Console.WriteLine("Место жительства: г. Ставрополь, пр. Кулакова 2/1");
            Console.WriteLine("Любимый предмет в школе: Информатика");
            Console.WriteLine("Увлечения, хобби, интересы: Программирования, Машины, Автогонки, Игра на гитаре, Баскетболл, Шахматы");
            Console.ReadKey();
            part_2();
        }
        static void part_2()
        {
            Console.WriteLine("");
            Console.WriteLine("Часть 2 (Вариант №14)");
            int a = 5;
            int z = 15;
            float Et = 156.5f;
            float Zze = ((35 / a) * z) + (z * a) - ((a + Et) / 4);
            Console.WriteLine("a={0}; z={1}; Et={2}", a, z, Et);
            Console.WriteLine("Zze = ((35 / a) * z) + (z * a) - ((a + Et) / 4)");
            Console.WriteLine("Результат: Zze={0}", Zze);
            Console.ReadKey();
        }
    }
}
