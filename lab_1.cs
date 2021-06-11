using System;

namespace test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var result = GetResult(new int[] { 4, 4, 5, 6, 7 });
            Console.WriteLine(result);
            Console.Read();
        }

        static int GetResult(int[] numbers)
        {
            int limit = 0;
            // локальная функция
            bool IsMoreThan(int number)
            {
                return number > limit;
  
            return result;
        }
    }
}
