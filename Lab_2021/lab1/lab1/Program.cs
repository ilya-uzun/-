using System;

namespace lab1
{
    class Tacs
    {
        private int m = 0;
        private int n = 0;
        private int amount = 0;


        public void Read()
        {
            try{
                //чтение m
                string mString = Console.ReadLine();
                m = Convert.ToInt32(mString);
                //чтение n
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
            Console.WriteLine("--m-n++  =  " + amount);
        }

        public bool Comparison()
        {
            if (m > n) 
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Tacs tacs = new Tacs();
            tacs.Read();
            tacs.Print();
            Console.WriteLine("Hello World!");
        }
    }
}
