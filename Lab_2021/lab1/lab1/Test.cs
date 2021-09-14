using System;
namespace lab1
{
    public class Test
    {

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


        public float[] GetArray()
        {
            int size = ReadSizeArrey();
            Random rnd = new Random();
            float[] temp = new float[size]; // выделить память для массива
            int random = 
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



