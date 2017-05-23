using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoStore;
using Moq;
using VideoStore.Factories;

namespace VideoStoreTests
{
    [TestClass]
    public class RentalTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var daysRented = 2;
            var movie = new Movie("test", MoviePriceCode.NewRelease);
            var rental = RentalFactory.CreateRental(movie, daysRented);
            Assert.AreEqual(movie, rental.Movie);
            Assert.AreEqual(daysRented, rental.DaysRented);
        }
    }
}
