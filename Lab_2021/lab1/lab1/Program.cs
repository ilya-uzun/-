using System;

namespace lab1
{
    class Tacs
    {
        private int m = 1;
        private int n = 1;

        public void print1()
        {
            Console.WriteLine("--m-n++  =  " + (--m - n++));
        }

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Tacs tacs = new Tacs();
            tacs.print1();
            Console.WriteLine("Hello World!");
        }
    }
}
