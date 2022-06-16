using System;

namespace Interfaces
{
    // interface
    interface IGame
    {
        // interface methods (no body!)
        void Welcome(string name);
        void Play();
    }

    interface IWriteToFile
    {
        void WriteResults();
    }


    // class implements both interfaces (IGame and IWriteToFile)
    class Raffle : IGame, IWriteToFile
    {
        public void WriteResults()
        {
            // todo: code for writing results to a file
        }

        // content of the Welcome method
        public void Welcome(string name)
        {
            Console.WriteLine("Welcome to play the  " + name);
        }

        // content of the Play method
        public void Play()
        {
            var rand = new Random();
            if (rand.Next(100) > 70)
            {
                Console.WriteLine("Yay you win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
        }
    }

    // another class implementing interface (only IGame)
    class Poker : IGame
    {
        public void Welcome(string name)
        {
            Console.WriteLine("Good luck on the game of " + name);
        }
        public void Play()
        {
            Console.WriteLine("You win!");
        }

        public void Suffle()
        {
            // todo: code for suffling cards
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Create object from a class
            Raffle lotto = new Raffle();

            // Use methods
            lotto.Welcome("lotto");
            lotto.Play();
            //lotto.Suffle();  // this does not work, Raffle class does not have Suffle method

            Poker pokeri = new Poker();
            pokeri.Welcome("poker");
            pokeri.Play();
            pokeri.Suffle();

        }
    }

}