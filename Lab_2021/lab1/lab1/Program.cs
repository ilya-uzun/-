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
           
            //test.ReadSizeRandom();
            //Console.WriteLine("{0:N}", test.GetArray());
            Console.WriteLine("Ввывод без массива");
            tacs.Formula();
            Console.WriteLine("Ввывод с массивом");
            tacs.Formula(test);


            */
            test.GetList();
            //Console.WriteLine("{0:N}", test.GetArray());


            Console.WriteLine("Вывод значениея Float");
            Console.WriteLine("{0:N}", tacs.FloatTacs3());
            Console.WriteLine("Вывод значениея Double");
            Console.WriteLine("{0:N}", tacs.Doubletacs3());
        }
    }
}
