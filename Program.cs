using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = 4;
            int firstElement = 2;
            int difference = 3;
            ComputeAritmeticSequence(lenght, firstElement, difference);
            
        }
        static void ComputeAritmeticSequence(int lenght, int firstElement, int difference)
        {
            int currentElement = firstElement;

            for(int i =1; i <= lenght; i++)
            {
                Console.WriteLine(currentElement);
                currentElement += difference;
            }
        }
    }
}
