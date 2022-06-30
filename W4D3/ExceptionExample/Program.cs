using System;
using System.IO;


namespace ExceptionExample
{
    class ExceptionExample
    {
        static void Main(string[] args)
        {
            try
            {
                // string[] text = File.ReadAllLines("/../../teksti.txt");

                int[] number = { 1, 2, 3, 7, 21, 4 };

                Console.WriteLine(number[4]);
                Console.WriteLine(number[8]);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("\nTiedostoa ei löytynyt\n");
                Console.WriteLine(e.ToString());
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("\nVirhe: IndexOutOfRangeException\n");
                Console.WriteLine(e.ToString());
            }
            catch (IOException e)
            {
                Console.WriteLine("\nJoku muu IO virhe\n");
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("\nJoku ihan muu virhe\n");
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("Hello o/");
        }
    }
}
