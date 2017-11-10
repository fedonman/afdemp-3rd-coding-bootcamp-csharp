using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssesment.UnitTests
{
    // Convert a normal class to a test class
    [TestClass]
    public class BankAssesmentTests
    {
        [TestMethod]
        public void ComputesHighestRate()
        {
            // Establish a reference from Tests Project to the main Project
            // Set the protection level right so you can create a RatingBook object
            RatingBook book = new RatingBook();
            book.AddRating(50);
            book.AddRating(70);

            RatingStats result = book.CalculateStats();
            Assert.AreEqual(70, result.HighestGrade);
            // What if someone changes the code inside CalculateStats. The developer will know cause the test will fail.
        }

        [TestMethod]
        public void ComputesLowestRate()
        {
            RatingBook book = new RatingBook();
            book.AddRating(19);
            book.AddRating(89);

            RatingStats result = book.CalculateStats();
            Assert.AreEqual(19, result.LowestGrade);
        }

        [TestMethod]
        public void ComputesAvegareGrade()
        {
            RatingBook book = new RatingBook();
            book.AddRating(56);
            book.AddRating(89.5f);
            book.AddRating(23);

            RatingStats result = book.CalculateStats();
            // Assertion made for float numbers
            Assert.AreEqual(56.16, result.AverageGrade, 0.01);
        }
    }
}
