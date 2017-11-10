using System;
using System.Collections.Generic;
using System.Linq;
// add using statement so the compiler knows 
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace BankAssesment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 2 - Referencing Assembly
            // Show how to add an assembly reference through solution Explorer by using add Reference option
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Speak("Hello this is a ball");

            // Part 1 - Create the Rating Book  
            // Store Ratings in my electronic book using my method addRating
            RatingBook book = new RatingBook();
            book.AddRating(34);
            book.AddRating(65.5f);

            //difference between double and float
            //double d = 78.8;
            //float fl = 78.8f;

            // Create a brand new instance of RatingBook
            book = new RatingBook();
            book.AddRating(72); // How many Ratings do we have after that?

            // Multiple Variables pointing to the same object
            // The value inside of book is not a RatingBook object, but a pointer to a RatingBook object
            // Copy that pointer into another variable. Now both book and book2 referencing the same RatingBook
            RatingBook book2 = book;
            book2.AddRating(89); // How many Ratings do we have after that?

            // Statics usage
            Console.WriteLine(RatingBook.MinimumRating);

            // When we want stats we tell the RatingBook to calculate them
            RatingStats stats = book.CalculateStats();
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.AverageGrade);

        }
    }
}
