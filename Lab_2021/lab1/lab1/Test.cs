using System;
namespace lab1
{
    public class Test
    {
        class arrey
        {
            public int value; // целочисленное значение
        }

        public Test()
        {
            sizeRandom = 0;
        }
        /* --- ----- Поля ----- ----- */

        private int sizeRandom;  // максимальное значение случайного числа
       // private int size; // зармер массива

        /* --- ----- Методы ----- ----- */
        static void GetArrey(ref arrey[] A, int size)
        {
            A = new arrey[size];
        }

        public void GetRandom()
        {
            Random rnd = new Random();
            for (int ctr = 0; ctr <= 5; ctr++)
                Console.WriteLine("{0:N}", rnd.NextDouble() * 10); 
        }

        public void ReadSizeRandom()
        {
            try
            {
                //запись 
                Console.Write("Введите верхнею границу случайного чисела: ");
                sizeRandom = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода ");
            }
        }//ReadSizeRandom()

        public int ReadSizeArrey()
        {
            int s = 0;
          try
            {
                //запись 
                Console.Write("Введите размер массива ");
                s = Convert.ToInt32(Console.ReadLine()); 
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода");
            }

            return s;
        }//ReadSizeRandom()
        /*
        public void GetRandomArrey()
        {
            Random rnd = new Random();
            //double[] myArrDouble = new double[size];
            //GetArrey(ref myArrDouble, size);
            //double[] myArrDouble = new double[size];
            foreach (int i in myArrDouble)
            {
                myArrDouble[i] = rnd.NextDouble() * sizeRandom;
                Console.WriteLine("{0:N}", myArrDouble[i]);
            }
        }//GetRandomArrey()  */

        public float[] GetArray()
        {
            int size = ReadSizeArrey();
            Random rnd = new Random();
            float[] temp = new float[size]; // выделить память для массива

            // заполнить массив значениями
            foreach (int i in temp)
            {
                temp[i] = (float)rnd.NextDouble() * sizeRandom;
                //Console.WriteLine("{0:N}", temp[i]); // проверка вывода
            }
            return temp;
        }

    }//Test
}



