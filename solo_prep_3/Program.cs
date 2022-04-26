using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,101);
            
            Console.WriteLine($"What is the magic number? {number}");
            int NumGuess = -1;
            while (NumGuess != number)
            {
                Console.Write("What is your guess? ");
                int NGuess = int.Parse(Console.ReadLine());

                if (NGuess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (NGuess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You Guessed it!");
                    break;
                }
                
            }

        }
    }
}