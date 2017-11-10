using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssesment
{
    // Default protection level for a class is internal (can be used only in the same assembly)
    // Any time we create a class we are creating a reference type
    public class RatingBook
    {
        // Part 1 - Create the Rating Book
        // Class Members define State and Behavior
        // RatingBook State : The Ratings for a Bank
        // RatingBook Behavior : 1. Add a new Rating, 2. Calculate Statistics
        // ==================================================================

        // Use FCL to store ratings by using a Field. Create a List from  System.Collections.Generic.
        // *Collections will be analyzed in a different Exercise
        // If we don't explicitly specify the access modifier, for a member of the class, the default is to make that member private
        // Storage for Ratings is encapsulated inside of the RatingBook
        private List<float> ratings;

        // Create a public field Name
        public string Name;
        // Statics
        // Use static members (field or method) of a class without creating an instance
        public static float MinimumRating = 0;

        // Constructor is a Special method used to initialize objects.
        public RatingBook()
        {
            ratings = new List<float>();
        }

        //Create the method to add Ratings to the book
        public void AddRating(float grade)
        {
            ratings.Add(grade);
        }

        // The RatingBook is responsible for storing the Ratings and compute stats
        public RatingStats CalculateStats()
        {
            RatingStats stats = new RatingStats();

            float sum = 0;

            foreach (float grade in ratings)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / ratings.Count;

            return stats;
        }
    }
}
