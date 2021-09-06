using System;
namespace lab1
{
    public class Test
    {
        public Test()
        {
        }
       
        private int size = 5;
        private int[] myArrInt = new int[5];
        private double[] myArrDouble = new double[5];

        public void GetRandom()
        {
            Random rnd = new Random();
            for (int ctr = 0; ctr <= 20; ctr++)
                Console.WriteLine("{0:N}", rnd.NextDouble() * 10); // максимальое знчение случайного числа 
            //myArrDouble = rnd.NextDouble();
        }
        /* public double RandomDouble()
         {
             return
         }*/
    }
}
