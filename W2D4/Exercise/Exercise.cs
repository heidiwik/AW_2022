using System;
using System.Threading;

/* 
 * Exercise: 
 * Add a custom extension method which tells the user what prize they win, but only if they win the game
 * 
 * Bonus Exercise:
 * Change the game logic to following:
 *  - ask a number 1-10 from user
 *  - if the number matches a random number given by Random() method, user wins 
 */


namespace Game
{
    public class Raffle
    {
        public bool victory;

        // display welcome message
        public void Welcome()
        {
            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("Welcome to the lotto game\n");
        }

        // show dots while raffling
        static void ShowDots()
        {
            int i = 0;
            while (i < 3)
            {
                Console.Write(".");
                Thread.Sleep(1000);
                i++;
            }
            Console.WriteLine("\n\n");
        }

        void GetResult()
        {
            var rand = new Random();
            if (rand.Next(100) > 70)
            {
                this.victory = true;
            }
            else
            {
                this.victory = false;
            }
        }

        // play the game
        public void Play()
        {
            Console.WriteLine("Press any key to play\n");
            Console.ReadKey(true);
            Console.Write("Raffling ");
            ShowDots();
            GetResult();
        }
    }


    class Exercise
    {
        static void Main(string[] args)
        {

            Raffle lotto = new Raffle();

            lotto.Welcome();
            lotto.Play();

            if (lotto.victory)
            {
                Console.WriteLine(" Congratulations! You won! \n");
            }
            else
            {
                Console.WriteLine(" You lost :( \n No price for you\n");
            }

            Console.WriteLine("*********************************");
        }
    }
}