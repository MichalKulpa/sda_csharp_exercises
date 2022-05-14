using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj cenę produktu:");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj liczbę produktów:");
                int quantity = Convert.ToInt32(Console.ReadLine());
                PriceList(price, quantity);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void PriceList(int price, int quantity)
        {
            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine($"Liczba sztuk: {i}, łączna cena {i * price} zł.");
            }
        }
    }
}
