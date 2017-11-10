using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = 10;
            int maximumGuesses = 3;
            int guesses = 0;

            int currentGuess, previousGuess = -1;

            while (true)
            {
                Console.Write("Take a guess!: ");
                currentGuess = int.Parse(Console.ReadLine());
                if (currentGuess == secret)
                {
                    Console.WriteLine("Hooray!!!");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    if (currentGuess > secret)
                    {
                        Console.WriteLine("You guessed too high!");
                    }
                    else
                    {
                        Console.WriteLine("You guessed too low!");
                    }
                    if (currentGuess != previousGuess)
                    {
                        guesses++; 
                        if (guesses == maximumGuesses)
                        {
                            Console.WriteLine("Sorry! No more guesses!");
                            Console.ReadKey();
                            return;
                        }
                    }
                    previousGuess = currentGuess;
                }
            }
        }
    }
}
