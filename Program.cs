using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string password1 = "AlaMa2$";
            string password2 = "Niewiem";
            Console.WriteLine(IsCorrect(password1));
            Console.WriteLine(IsCorrect(password2));
            
        }
        static bool IsCorrect(string password)
        {
            return IsSixCharLong(password) && HasDigits(password) && HasLowerAndUpper(password) && HasSpecialChar(password);
        }
        static bool IsSixCharLong(string password)
        {
            return password.Length >= 6;
        }
        static bool HasLowerAndUpper(string password)
        {
            int lowerCount = 0;
            int upperCount = 0;
            char[] characters = password.ToCharArray();
            for(int i =0; i<characters.Length;i++)
            {
                if (char.IsUpper(characters[i])) upperCount++;
                else if (char.IsLower(characters[i])) lowerCount++;
            }
            return lowerCount > 0 && upperCount > 0;
        }
        static bool HasDigits(string password)
        {
            int digitCount = 0;
            char[] characters = password.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                if (char.IsDigit(characters[i])) digitCount++;
            }
            return digitCount >0;

        }
        static bool HasSpecialChar(string password)
        {
            int specialCount = 0;
            char[] characters = password.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i]=='&' || characters[i]=='*' || characters[i]=='$' || characters[i]=='#') specialCount++;
            }
            return specialCount > 0;
        }

    }
}
