using System;
using System.Threading;

/* 
 * Exercise: 
 * Recognise parts that can throw an error
 * Modify the code and add error handling where needed  
 */


namespace BrokenLottoGame
{
    public class Raffle
    {
        public bool victory;
        public int guessedNumber;
        public int victoryNumber;
        public string[] price = new string[]
        {
            "Pony",
            "One million dollars",
            "Bike",
            "Hat",
            "Ice cream"
        };

        public void Welcome()
        {
            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("Welcome to the lotto game\n");
        }

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
            victoryNumber = rand.Next(10);

            if (victoryNumber == guessedNumber)
            {
                victory = true;
            }
            else
            {
                victory = false;
            }
        }

        public void Play()
        {

            try
            {
                //guessedNumber = int.Parse(Console.ReadLine());

                bool isNumber = false;

                while (isNumber == false)
                {
                    Console.WriteLine("Guess a number between 1-10:\n");
                    isNumber = int.TryParse(Console.ReadLine(), out guessedNumber);
                }

                Console.Write("\nGood luck!\n\nRaffling ");
                ShowDots();
                GetResult();
            }
            catch (Exception e)
            {
                Console.WriteLine("Väärä syöte");
            }

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
                Console.Write(" Congratulations! You won ");
                Console.Write(lotto.price[lotto.victoryNumber]);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine(" Correct number was " + lotto.victoryNumber + "\n You lost :(  No price for you\n");
            }

            Console.WriteLine("*********************************");
        }
    }
}