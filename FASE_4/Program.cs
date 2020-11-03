using System;
using System.Collections.Generic;

namespace FASE_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> name = new List<char>() { 'J', 'o', 's', 'e', ' ', 'M', 'a', 'r', 'i', 'a' };
            List<char> surname = new List<char>() { 'A', 'l', 'v', 'a', 'r', 'e', 'z'};
            List<char> fullName = new List<char>();

            fullName.AddRange(name);
            fullName.AddRange(surname);
            fullName.Insert(name.Count, ' ');

            foreach(var letters in fullName)
            {
                Console.Write(letters);
            }

        }
    }
}
