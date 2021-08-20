using System;

namespace lab1
{
    class Tacs
    {
        private int m = 0;
        private int n = 0;

        public void print()
        {
            n++;
            int sima = n + m;
            Console.WriteLine("n+++m  =  " + sima);
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Tacs tacs = new Tacs();
            tacs.print();
            Console.WriteLine("Hello World!");
        }
    }
}
