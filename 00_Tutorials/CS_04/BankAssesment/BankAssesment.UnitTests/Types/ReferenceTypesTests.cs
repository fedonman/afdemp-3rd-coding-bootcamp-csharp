using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssesment.UnitTests.Types
{
    [TestClass]
    public class ReferenceTypesTests
    {
        // Inside this class we will write some assertions based on what we believe should happen
        // and then run the test to see if our beliefs are true.

        // Code snippet - type testm then tab twice nad create a test method
        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            // With reference types we can point two variables to the same object, and then make a change to that object through 
            // either of those variables, and the change will be visible to the other variable but that is not the case with value types
            // When we changed the value of x1 it does not reflect to x2
            int x1 = 100;
            int x2 = x1;

            x1 = 4;

            Assert.AreNotEqual(x1, x2);
            // x1 holds the value 4, x2 holds the value 100
        }

        [TestMethod]
        public void VariablesHoldAReference()
        {
            // Part 2 - References
            RatingBook r1 = new RatingBook();
            // The value that is inside of r1 variable is going to be a pointer
            RatingBook r2 = r1;
            // Now we have two variables pointing to the exact same object
            // what if ...
            // r1 = new RatingBook();
            r1.Name = "My Rating Book";
            Assert.AreEqual(r1.Name, r2.Name);
            // We will do some testing in the unit tests about reference types
        }

        [TestMethod]
        public void StringComparisons()
        {
            // String is a reference type...press F12 over String to figure it out
            String name1 = "Peri";
            String name2 = "peri";

            // StringComparison is an enumeration
            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            RatingBook book1 = new RatingBook();
            RatingBook book2 = book1; // this line of code is copying the reference that is inside of book1 into book2
            // So now we have two variables pointing to the same object

            GiveBookAName(book2);
            Assert.AreEqual("My Grade Book", book1.Name);
            // test passed because the value inside of book2 is copied into the parameter book and that value is a pointer
            // Any changes that we make to the RatingBook through any of those variables they will be visible through any of the other variables
        }

        // This method takes a RatingBook parameter
        private void GiveBookAName(RatingBook book)
        {
            book.Name = "My Grade Book";
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 55;
            IncrementNumber(x);

            Assert.AreEqual(55, x);
        }
        // This method expects an integer parameter
        private void IncrementNumber(int number)
        {
            // Changes in variable number are only visible inside this block of code. That's because int is a value type
            number += 1;
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            // Use a constructor to create a new datetime object
            DateTime date = new DateTime(2014, 5, 16);
            //date.AddDays(1); wrong code cause AddDays constructs a new DateTime object
            date = date.AddDays(1);

            Assert.AreEqual(17, date.Day);
        }

        [TestMethod]
        public void UpperCaseString()
        {
            string name = "peri";
            // Method To Upper dont modify the string but instead it creates a new string, so we need to capture that by assigning a reference to that new string
            name = name.ToUpper();

            ToUpperCase(name);

            Assert.AreEqual("PERI", name);
        }

        [TestMethod]
        public void StringTest()
        {
            string college = "NYC";
            ToUpperCase(college);

            Assert.AreNotEqual("skjhfsdjg", college);
            // String is a reference type but it behaves like a value type in many ways because string is immutable
        }

        private void ToUpperCase(string name)
        {
            name = "skjhfsdjg";
        }
    }
}
