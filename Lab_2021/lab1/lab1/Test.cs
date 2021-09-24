using System;
using System.Collections.Generic;

namespace lab1
{
    public class Test
    {

        public Test()
        {
            minSizeRandom = 0;
            maxSizeRandom = 0;
        }
        /* --- ----- Поля ----- ----- */

        private int minSizeRandom;  // минимальное значение случайного числа
        private int maxSizeRandom;  // максимальное значение случайного числа


        /* --- ----- Методы ----- ----- */
        public int GetMinSizeRandom()
        {
            return minSizeRandom;
        }

        public int GetMaxSizeRandom()
        {
            return maxSizeRandom;
        }

        public void GetRandom()
        {
            Random rnd = new Random();
            for (int ctr = 0; ctr <= 5; ctr++)
                Console.WriteLine("{0:N}", rnd.NextDouble() * 10); 
        }

        public void ReadSizeRandom()
        {
            try
            {
                //запись 
                Console.Write("Введите нижнею границу случайного чисела: ");
                minSizeRandom = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите верхнею границу случайного чисела: ");
                maxSizeRandom = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода ");
            }
        }//ReadSizeRandom()

        public int ReadSizeArrey()
        {
            int s = 0;
          try
            {
                //запись 
                Console.Write("Введите размер массива ");
                s = Convert.ToInt32(Console.ReadLine()); 
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода");
            }

            return s;
        }//ReadSizeRandom()


       public int[] GetArray()
        {
            int size = ReadSizeArrey(); // запрос на размер массива
            Random rnd = new Random();
            int[] temp = new int[size]; // выделить память для массива
            ReadSizeRandom(); // запрос на верзнюю границе радомных чисел
            // заполнить массив значениями
            Console.WriteLine("Сгенерированный массив");
            foreach (int i in temp)
            {
                temp[i] = rnd.Next(minSizeRandom, maxSizeRandom);
                Console.Write(" " + temp[i]); // проверка вывода
            }
            Console.WriteLine(""); // новая строка
            return temp;
        }

        public List<int> GetList(){
            List<int> myX = new List<int>();
            foreach (int i in myX)
            {
                return myX;
            }
        }

    }//Test
}


