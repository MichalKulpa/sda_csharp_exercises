using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(3));
        }
        static int Factorial(int num)
        {
            int result = 1;
            for(int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
