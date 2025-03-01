﻿using System;

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
            Console.Write("Задача 6. Введите количесво целых чисел : ");
            try
            {

                int buf = Convert.ToInt32(Console.ReadLine()), min = int.MaxValue, val = -1;
                for (; buf > 0; buf--) 
                {
                    Console.Write("Введите чисел ");
                    val = Convert.ToInt32(Console.ReadLine());
                    min = min > val ? val : min;
                }
                Console.WriteLine("min : " + min);
            }
            catch
            {
                Console.WriteLine("Ошибка ввода ");
            }

            /*
             Задача № 29
             Дана последовательность целых чисел, за которой следует 0. Найти количество нечетных элементов этой последовательности.
            */
            Console.Write("Задача 29. Введите количесво целых чисел  ");
            try
            {
                int counter = 0;
                int[] arr = new int[10];
                Random rand = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(1, 100);
                    Console.Write(arr[i] + " ");

                }
                Console.WriteLine();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 3 == 0 && arr[i] != 0)
                    {
                        counter++;
                    }

                }

                Console.WriteLine("Нечетных чисел: " + counter);
            
            }
            catch
            {
                Console.WriteLine("Ошибка ввода ");
            }

            /*
             Задача № 40
             S= sin X + sin^2 X + sin^3 X + sin^4 X +...+ sinX^n
            */
            
            try
            {
                double S = 0.0f;
                Console.Write("Задача 40. Введите число итераций для суммы ряда : ");
                double num = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Введите x : ");
                double x = Convert.ToDouble(Console.ReadLine());
                for (int i = 0; i <= num; i++) 
                {
                    double n = 1;
                    S += pow(sin(x),n);
                    n++;
                }
                Console.WriteLine("S = sin X + sin^2 X + sin^3 X + sin^4 X +...+ sinX^n " + S);
            }
            catch
            {
                Console.WriteLine("Ошибка ввода ");
            }
        }
    }
}
