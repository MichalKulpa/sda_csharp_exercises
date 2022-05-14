using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "ElitaSorbet";
            string leetWord = Speak1337(word);
            Console.WriteLine(leetWord);
            Console.WriteLine(Speak1337Decoder(leetWord));

        }
        static string Speak1337(string word)
        {
            char[] leetLetters = { '4', '3', '1', '0', '$' };
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };
            word = word.ToLower();
            char[] characters = word.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                for (int j = 0; j < naturalLetters.Length; j++)
                {
                    if (characters[i] == naturalLetters[j])
                    {
                        characters[i] = leetLetters[j];
                    }
                }
            }
            string newWord = new string(characters);
            return newWord;
        }
        static string Speak1337Decoder(string word)
        {
            char[] leetLetters = { '4', '3', '1', '0', '$' };
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };
            word = word.ToLower();
            char[] characters = word.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                for (int j = 0; j < leetLetters.Length; j++)
                {
                    if (characters[i] == leetLetters[j])
                    {
                        characters[i] = naturalLetters[j];
                    }
                }
            }
            string newWord = new string(characters);
            return newWord;
        }
    }
}
