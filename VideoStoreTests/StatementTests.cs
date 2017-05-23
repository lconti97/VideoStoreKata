using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoStore;

namespace VideoStoreTests
{
    [TestClass]
    public class StatementTests
    {
        private Customer customer;

        [TestInitialize]
        public void SetUp()
        {
            customer = new Customer("Fred");
        }

        [TestMethod]
        public void TestSingleNewReleaseHTMLStatement()
        {
            customer.AddRental(new Rental(new Movie("The Cell", MoviePriceCode.NewRelease), 3));
            var expectedStatement = String.Format("Rental Record for Fred{0}{1}The Cell{1}9.0{0}You owed 9.0{0}You earned 2 frequent renter points{0}", "<br />", "&nbsp");
            IStatement actualStatement = new HTMLStatement(customer);
            Assert.AreEqual(expectedStatement, actualStatement.Print());
        }

        [TestMethod]
        public void TestSingleNewReleaseStatement()
        {
            customer.AddRental(new Rental(new Movie("The Cell", MoviePriceCode.NewRelease), 3));
            var expectedStatement = "Rental Record for Fred\n" +
                "\tThe Cell\t9.0\n" +
                "You owed 9.0\n" +
                "You earned 2 frequent renter points\n";
            IStatement actualStatement = new TextStatement(customer);
            Assert.AreEqual(expectedStatement, actualStatement.Print());
        }
    }
}
