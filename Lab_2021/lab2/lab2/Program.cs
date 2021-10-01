using System;

namespace lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
             Задача №6
             Дана последовательность из n целых чисел. Найти минимальный элемент в этой последовательности.
            */
            Console.Write("Введите количесво целых чисел ");
            try
            {
                int buf = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка ввода ");
            }

            /*
             Задача № 29
             Дана последовательность целых чисел, за которой следует 0. Найти количество нечетных элементов этой последовательности.
            */
            Console.Write("Введите количесво целых чисел ");
            try
            {
                int buf = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка ввода ");
            }

            /*
             Задача № 40
             S= sin X + sin X^2 + sin X^3 + sin X^4 +...+ sin X^n 
            */

        }
    }
}
