using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int number = random.Next(10, 20);

            int guesscount = 0;
            int maxguess = 5;
            bool win = false;


            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            CheckGuesss(win, number, guesscount, maxguess);

            
            Console.ReadKey();

           
        }

        public static void CheckGuesss(bool win, int number, int guesscount, int maxguess)
        {
            while (!win && guesscount < maxguess)
            {

                int guess = int.Parse(Console.ReadLine());
                guesscount++;

                if (guess < number)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                }
                else if (guess == number)
                {
                    Console.WriteLine("Woho! Du gjorde det!");
                    win = true;
                }
            }

            if (!win)
            {
                Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
            }


        }


    }
}
