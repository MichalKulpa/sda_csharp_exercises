using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawTriangle(3, '*');
          
        }
        static void DrawTriangle(int size, char character)
        {
            for(int i =0; i < size; i++)
            {
                Console.Write(character);
                for (int j = 0; j < i; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
            }
            for (int i = size; i > 1; i--)
            {
                for(int j = i; j > 1; j--)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
            }
        }
    }
}
