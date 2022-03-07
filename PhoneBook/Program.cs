using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //vytvoření slovníku
            Dictionary<string, string> seznamTelCisel = new Dictionary<string, string>();
            Console.WriteLine("Kolik chcete zadat čísel?");

            //do proměnné pocetCisel načteme kolik chce uživatel zadat čísel
            int pocetCisel = Convert.ToInt32(Console.ReadLine());

            //cyklus běží do doby, než se narazí na strop daný zadaným počtem čísel
            for(int i = 0; i < pocetCisel; i++)
            {
                string jmenoTelCisla = "";;
                Console.WriteLine("Zadej jméno uživatele: ");
                jmenoTelCisla = Console.ReadLine();

                Console.WriteLine("Zadej číslo: ");
                string telCislo = Console.ReadLine();

                seznamTelCisel.Add(jmenoTelCisla, telCislo);

                Console.Clear();
            }
            foreach(var radekZeSeznamu in seznamTelCisel)
            {
                Console.WriteLine($"Jméno {radekZeSeznamu.Key} tel. číslo: {radekZeSeznamu.Value}");
            }
        }
    }
}
