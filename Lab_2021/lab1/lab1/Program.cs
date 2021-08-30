﻿using System;

namespace lab1
{
    class Tacs1
    {
        private int m = 0;
        private int n = 0;
        private int amount = 0;


        public void Read()
        {
            try{
                //запись m
                Console.WriteLine("Введите m : ");
                string mString = Console.ReadLine();
                m = Convert.ToInt32(mString);
                //запись n
                Console.WriteLine("Введите n : ");
                string nString = Console.ReadLine();
                n = Convert.ToInt32(nString);
            }
            catch (FormatException)
            {
                Console.WriteLine("ошибка ввода ");
            }
        }

        public void Print()
        {
            amount = m - (++n);
            Console.WriteLine("Вырожение m-++n  =  " + amount);
        }

        public void Comparison()
        {
            m++;
            n--;
            if (m > n)  Console.WriteLine("m++>--n");
  
        }

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Tacs1 tacs = new Tacs1();
            Console.WriteLine("Введите m и n");
            tacs.Read();
            tacs.Comparison();
            tacs.Print();

        }
    }
}
