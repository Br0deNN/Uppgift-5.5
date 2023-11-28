using System;
using System.Globalization;

namespace uppggift_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            string x = "";
            string[] svar = { "ja", "nej", "niet", "priviet", "vodka", "hell no", "ursäkta", "euw", "holymoly", "låter bra" };

            Console.WriteLine("Vill du ställa en fråga? Om du vill skriv då: Ja och om du vill avlsuta skriv då: a");
            string y = Console.ReadLine();

            while (y == "Ja")
            {
                Console.WriteLine("Ställ din fråga");
                string fråga = Console.ReadLine();
                Console.WriteLine(svar[slump.Next(10)]);

                Console.WriteLine("Vill du ställa en till fråga? Ja/a");
                y = Console.ReadLine();
            }
            if (y == "a")
            {
                Console.WriteLine("Programmet avslutas");
            }
        }
    }
}