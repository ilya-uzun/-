﻿using System;
namespace lab1
{
    public class Test
    {
        public Test()
        {
            sizeRandom = 0;
            size = 2;
            //myArrDouble = new double[size];
        }
        /* --- ----- Поля ----- ----- */

        private int sizeRandom;  // максимальное значение случайного числа
        private int size;

        /* --- ----- Методы ----- ----- */
        public void GetArrey(ref arrey[])
        {
            double[] arrey = new double[size];

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
                Console.Write("Верхнею границу случайного чисела: ");
                sizeRandom = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("ошибка ввода ");
            }
        }//ReadSizeRandom()

        public void ReadSizeArrey()
        {
            try
            {
                //запись 
                Console.Write("Ведите размер массива ");
                size = Convert.ToInt32(Console.ReadLine()); 
            }
            catch (FormatException)
            {
                Console.WriteLine("ошибка ввода");
            }
        }//ReadSizeRandom()

        public void GetRandomArrey()
        {
            Random rnd = new Random();
            double[] myArrDouble = new double[size];
            foreach (int i in myArrDouble)
            {
                myArrDouble[i] = rnd.NextDouble() * sizeRandom;
                Console.WriteLine("{0:N}", myArrDouble[i]);
            }
        }//GetRandomArrey()
    }//Test
}