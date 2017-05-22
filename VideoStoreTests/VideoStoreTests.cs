using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoStore;

namespace VideoStoreTests
{
    [TestClass]
    public class VideoStoreTests
    {
        [TestInitialize]
        public void SetUp()
        {
            customer = new Customer("Fred");
        }

        [TestMethod]
        public void TestSingleNewReleaseStatement()
        {
            customer.AddRental(new Rental(new Movie("The Cell", Movie.NEW_RELEASE), 3));
            Assert.AreEqual("Rental Record for Fred\n" +
                "\tThe Cell\t9.0\n" +
                "You owed 9.0\n" +
                "You earned 2 frequent renter points\n", customer.statement());
        }

        [TestMethod]
        public void TestDualNewReleaseStatement()
        {
            customer.AddRental(new Rental(new Movie("The Tigger Movie", Movie.NEW_RELEASE), 3));
            customer.AddRental(new Rental(new Movie("The Cell", Movie.NEW_RELEASE), 3));
            Assert.AreEqual("Rental Record for Fred\n" +
                "\tThe Cell\t9.0\n" +
                "\tThe Tigger Movie\t9.0\n" +
                "You owed 18.0\n" +
                "You earned 4 frequent renter points\n", customer.statement());
        }

        [TestMethod]
        public void TestSingleChildrensStatement()
        {
            customer.AddRental(new Rental(new Movie("The Tigger Movie", Movie.CHILDRENS), 3));
            Assert.AreEqual("Rental Record for Fred\n" +
                "\tThe Tigger Movie\t1.5\n" +
                "You owed 1.5\n" +
                "You earned 1 frequent renter points\n", customer.statement());
        }

        [TestMethod]
        public void TestMultipleRegularStatement()
        {
            customer.AddRental(new Rental(new Movie("Plan 9 from Outer Space", Movie.REGULAR), 1));
            customer.AddRental(new Rental(new Movie("8 1/2", Movie.REGULAR), 2));
            customer.AddRental(new Rental(new Movie("Eraserhead", Movie.REGULAR), 3));

            //var expected = @"Rental Record for Fred\n
            //    \tEraserhead\t3.5\n
            //    \t8 1/2\t2.0\n
            //    \tPlan 9 from Outer Space\t2.0\n
            //    You owed 7.5\n
            //    You earned 3 frequent renter points\n";

            //Assert.AreEqual(expected, customer.statement());
            Assert.AreEqual("Rental Record for Fred\n" +
                "\tEraserhead\t3.5\n" +
                "\t8 1/2\t2.0\n" +
                "\tPlan 9 from Outer Space\t2.0\n" +
                "You owed 7.5\n" +
                "You earned 3 frequent renter points\n", customer.statement());
        }

        private Customer customer;
    }
}
