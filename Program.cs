using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj podstawę: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj wykładnik: ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y > 0)
            {
                Console.WriteLine(Math.Pow(x, y));
            }
            else
            {
                Console.WriteLine("Wykładnik jest ujemny, podaj inny.");
            }
        }
    }
}
