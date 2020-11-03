using System;

namespace FASE_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] name = new char[] {'J', 'o', 's', 'e', ' ', 'M', 'a', 'r', 'i', 'a'};

            for(int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]);
            }
        }
    }
}
