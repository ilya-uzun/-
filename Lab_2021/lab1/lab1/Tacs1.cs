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
         x = 0.0;
         }

        private int m, n, amount;
        private double x;
    

        public void Read()
        {
            try
            {
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
        }//Read()

        public void ReadX()
        {
            try
            {
                //запись x
                Console.WriteLine("Введите x : ");
                string xString = Console.ReadLine();
                x = Convert.ToDouble(xString);
            }
            catch (FormatException)
            {
                Console.WriteLine("ошибка ввода ");
            }
        }//ReadX()

        public void PrintAmount()
        {
            amount = m - (++n);
            Console.WriteLine("Вырожение m-++n  =  " + amount);
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

        public double Formula()
        {
            return 25 * Math.Pow(x, 5) - Math.Sqrt(x * x + x);
        }
    }//Tacs1
}
