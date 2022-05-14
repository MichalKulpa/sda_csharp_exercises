using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string pesel = "55030101193";
            Console.WriteLine(PeselIsCorrect(pesel));

        }
        static int SumOfPeselProducts(int[] pesel)
        {
            int sum=0;
            int[] imprtances = {1,3,7,9,1,3,7,9,1,3,1 };
            for(int i = 0; i < 10; i++)
            {
                
                sum = +pesel[i] * imprtances[i];
            }
            return sum;
        }
        static int[] PeselToIntArray(string pesel)
        {
            int[] peselIntArray=new int [11];
            char[] peselCharArray = pesel.ToCharArray();
            for (int i = 0; i < peselCharArray.Length; i++)
            {
                peselIntArray[i] = Convert.ToInt32(peselCharArray[i]);
                
            }
            return peselIntArray;
        }
        static int PeselModulo(int sum)
        {
            return sum % 10;
        }
        static bool PeselIsCorrect(string pesel)
        {
            int[] peselArray = PeselToIntArray(pesel);
            int sum = SumOfPeselProducts(peselArray);
            //Console.WriteLine(sum);
            return 10 - PeselModulo(sum) == peselArray[10] ;
        }


    }
}
