using System;
using System.Collections.Generic;

namespace lab1
{
     public class Tacs1
    {

        public Tacs1()
        {
         m = 0;
         n = 0;
         amount = 0;
         x = 0.0f;
         }

        /* --- ----- Поля ----- ----- */
       
        private int m, n, amount;
        private int a = 100;
        private double b = 0.001;
        private float x;

        /* --- ----- Методы ----- ----- */
        public void Read()
        {
            try
            {
                //запись m
                Console.Write("Введите m : ");
                m = Convert.ToInt32(Console.ReadLine());
                //запись n
                Console.Write("Введите n : ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("ошибка ввода ");
            }
        }//Read()

        public void ReadX()
        {
            try
            {
                //запись x
                Console.Write("Введите x : "); 
                //Convert.    
                x = (float)Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("ошибка ввода ");
            }
        }//ReadX()

        public void PrintAmount()
        {
            amount = m - (++n);
            Console.WriteLine("Вырожение m- ++n  =  " + amount);
        }

        public void Print()
        {
            Console.WriteLine("Вырожение m =  " + m);
            Console.WriteLine("Вырожение n =  " + n);
        }

        public void Comparison()
        {
            m++;
            n--;
            if (m > n)
            {
                Console.WriteLine("m++>--n");
            }
            else
            {
                Console.WriteLine("Условие не выполненно m++>--n");
            }
        }//Comparison()

        public void Comparison2()
        {
            m--;
            n++;
            if (m < n)
            {
                Console.WriteLine("m--<++n");
            }
            else
            {
                Console.WriteLine("Условие не выполненно m--<++n");
            }
        }//Comparison2()

        public void Formula()
        {
            int zero = 0;
            ReadX();
            zero = (int) (25 * (float)Math.Pow(x, 5) - (float)Math.Sqrt(x * x + x));
            if (zero == 0)
            {
                Console.WriteLine("Является корне уровнения x = " + x);

            }else Console.WriteLine("Не является корне уровнения x = " + x);
    
            /*Преобразование в float выполнено, 
              поскольку функции класса Math возвращают тип double.
              Тап float использован т.к нет необходимости в большой точности */
        }
        public void Formula(Test t)
        {
            Test s = new Test(); // создае объект класса тест
            Random rnd = new Random();
            List<int> myX = new List<int>(); // создаем список для копирования тестового массива
            int size = s.ReadSizeArrey(); // запрос на размер массива
           
           
            s.ReadSizeRandom(); // запрос на верзнюю границе радомных чисел
            // заполнить массив значениями
            Console.WriteLine("Сгенерированный массив");

         
            //Заполнение списка
            foreach (int i in myX)
            {
                myX[i] = rnd.Next(s.GetMinSizeRandom(), s.GetMaxSizeRandom());
                Console.Write(" " + myX[i]); // проверка вывода
            }
            Console.WriteLine(""); // новая строка
       

            int zero = 0;
            /*
             * Создать новый список
             * Проверить как все работает
           */

            foreach (int i in myX) 
            {
   
                zero = (int)(25 * Math.Pow(myX[i], 5) - Math.Sqrt(myX[i] * myX[i] + myX[i]));

                if (zero == 0)
                {
                    Console.Write("Является корне уровнения x = ");
                    Console.WriteLine("{0}", myX[i]);
                }
                Console.WriteLine("{0}", myX[i]);
            }
            // подумать стоит ли передовать float в поиск если потом все равно перевожу в int
        }

        public double Doubletacs3()
        {
            double suma = Math.Pow((a-b), 3) - (Math.Pow(a,3)+ 3*a*b*b) / -(3*a*a*b-Math.Pow(b,3));
            return suma;
        }
        public float FloatTacs3()
        {
            float suma = (float)(Math.Pow((a - b), 3) - (Math.Pow(a, 3) + 3 * a * b * b) / -(3 * a * a * b - Math.Pow(b, 3)));
            return suma;
        }

    }//Tacs1
}
