using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 1, 2, 5 };
            RemoveDuplicates(numbers);
        }
        static void RemoveDuplicates(int[] numbers)           
        {
            for(int i = 0;i<numbers.Length;i++)
            {
                for(int j=i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j]) numbers[j] = -1;

                }
                if (numbers[i] >= 0) Console.Write(numbers[i]+" ");
            }

                       
        }
    }
}
