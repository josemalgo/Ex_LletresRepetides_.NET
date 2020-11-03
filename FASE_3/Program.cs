using System;
using System.Collections.Generic;

namespace FASE_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> name = new List<char>() { 'J', 'o', 's', 'e', ' ', 'M', 'a', 'r', 'i', 'a' };
            Dictionary<char, int> countLetters = new Dictionary<char, int>();

            foreach (var letters in name)
            {
                char capitalLetter = Char.ToUpper(letters);
                
                if (char.IsLetter(letters))
                {
                    if (!countLetters.ContainsKey(capitalLetter))
                    {
                        countLetters.Add(capitalLetter, 1);
                    }
                    else
                    {
                        countLetters[capitalLetter]++;
                    }
                }
            }

            foreach (var vowels in countLetters)
            {
                Console.WriteLine(vowels.Key + " - " + vowels.Value);
            }
        }
    }
}
