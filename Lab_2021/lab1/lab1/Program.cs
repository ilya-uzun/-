using System;

namespace lab1
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Tacs1 tacs = new Tacs1();
            Test test = new Test();
            Console.WriteLine("Введите m и n");
            /*
            tacs.Read();
            tacs.PrintAmount();
            tacs.Comparison();
            tacs.Print();
            tacs.Comparison2();
            tacs.Print();
            Console.WriteLine("Введите x ");
            tacs.ReadX();
            Console.Write("Вывод формулы x ");
            Console.WriteLine("{0:N}", tacs.Formula());
            */
            test.ReadSizeRandom();
            //test.ReadSizeArrey();
            //test.GetRandom();
            test.GetRandomArrey();
        }
    }
}
