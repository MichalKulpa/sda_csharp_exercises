using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 2, 8, 1, 0, 3 };
            PrintArray(BubbleSort(array));
        }
        static void PrintArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static int[] BubbleSort(int[] array)
        {
            int temporary=0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {

                        temporary = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temporary;
                    }
                }
            }

            return array;
        }
    }
}
