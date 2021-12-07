using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikult numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis see kasutaja on selle mängu võitnud
            //katsete arv on piiramatu
            //* programm genereerib juhuslikku numbrit vaid üks kord. 

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool game = true;

            
            //Console.WriteLine("Cheat: " + cpuNumber);

            while (game)
            {
                Console.WriteLine("Pakkuge üks number 1 kuni 10");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuNumber == userNumber)
                {
                    Console.WriteLine("Palju õnne! Õige vastus.");
                    game = false;
                }
                else { Console.WriteLine("Proovi uuesti!"); }        
            }
        }
    }
}
