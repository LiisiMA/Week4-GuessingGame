using System;

namespace GuessingGameThreeTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikult numbrit 1 kuni 10;
            //kasutaja peab seda umbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis see kasutaja on selle mängu võitnud
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti
            //* programm genereerib juhuslikku numbrit vaid üks kord. 

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            //Console.WriteLine("Cheat: " + cpuNumber);
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta suvaline number 1 kuni 10");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuNumber == userNumber)
                {
                    Console.WriteLine("Palju õnne! Võitsid mängu!");
                    break;
                }
                else
                {
                    i++;
                    if (i == 3) 
                    { 
                        Console.WriteLine("Oled mängu kaotanud."); 
                        break; 
                    }
                Console.WriteLine($"Vale vastus. { 3 - i} katset on jäänud");
                }

            }

            
        }
    }
}
