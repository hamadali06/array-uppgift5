using System;

namespace Inlamning
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] svar = { "Ja", "Nej", "Kanske", "Försök igen", "Absolut", "Ahmad är inte här", "Fråga senare", "Definitivt", "Troligen", "Möjligen" };
            Random slump = new Random();
            while (true)
            {
                Console.WriteLine("Ställ en fråga (eller skriv 'a' för att avsluta):");
                string fråga = Console.ReadLine();
                if (fråga == "a") break;
                Console.WriteLine(svar[slump.Next(svar.Length)]);
            }
        }
    }
}
