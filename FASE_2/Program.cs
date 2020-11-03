using System;
using System.Collections.Generic;

namespace FASE_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> name = new List<char>() { 'J', 'o', 's', 'e', ' ', 'M', 'a', 'r', 'i', 'a' };

            foreach (var letters in name)
            {
                List<char> vowels = new List<char>() { 'A', 'E', 'I', 'O', 'U' };

                if (Char.IsLetter(letters))
                {
                    if (vowels.Contains(Char.ToUpper(letters)))
                        Console.WriteLine(letters + " VOCAL.");
                    else
                        Console.WriteLine(letters + " CONSONANT.");
                }
                else if (Char.IsNumber(letters))
                    Console.WriteLine(letters + " Els noms de persones no contenen números.");

            }
        }
    }
}
