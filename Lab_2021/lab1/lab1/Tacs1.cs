using System;

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
            zero = (int) (25 * (float)Math.Pow(x, 5) - (float)Math.Sqrt(x * x + x));
            if (zero == 0)
            {
                Console.WriteLine("Х является корне уровнения " + x);

            }
            //return 25 * (float)Math.Pow(x, 5) - (float)Math.Sqrt(x * x + x);
            /*Преобразование в float выполнено, 
              поскольку функции класса Math возвращают тип double.
              Тап float использован т.к нет необходимости в большой точности */
        }
        public void Formula(Test t)
        {

            float x2 = 0.0f;
            int zero = 0;
            Test s = new Test();
            
            foreach (int i in s.GetArray())
            {
              // ???  x2 = s.GetArray();
            }

               
            zero = (int) (25 * (float)Math.Pow(x2, 5) - (float)Math.Sqrt(x2 * x2 + x2));

            foreach (int i in s)
            {
                temp[i] = (float)rnd.NextDouble() * sizeRandom;
                //Console.WriteLine("{0:N}", temp[i]); // проверка вывода
            }

            if (zero == 0)
            {
               Console.WriteLine("Х является корне уровнения " + x2);
            }

        }
    }//Tacs1
}
