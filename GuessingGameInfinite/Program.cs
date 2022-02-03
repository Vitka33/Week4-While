using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv piiramatu.
            //programm genereerib juhusliku numbrit ühte korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            while (true)
            {
                Console.WriteLine("Sisesta oma mõeldud number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if(userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne, oled võitnud mängu!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine("Sina kaotasid! Proovi uuesti.");
                    Console.WriteLine($"Ktase number {i}");
                }
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
