using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> seznamZnamek = new List<int>();
            seznamZnamek.Add(5);
            seznamZnamek.Add(4);
            seznamZnamek.Add(3);
            seznamZnamek.Add(2);
            seznamZnamek.Add(1);
            seznamZnamek.Add(5);
            seznamZnamek.Add(4);

            double aritmetickyPrumer = 0;
            double soucetVsechCisel = 0;

            foreach(var hodnotaZeSeznamu in seznamZnamek)
            {
                soucetVsechCisel += hodnotaZeSeznamu;
            }
            aritmetickyPrumer = soucetVsechCisel / seznamZnamek.Count;
            Console.WriteLine(aritmetickyPrumer);
            //random
        }
    }
}
