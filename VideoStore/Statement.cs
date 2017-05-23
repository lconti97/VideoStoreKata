using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public abstract class Statement : IStatement
    {
        private Customer customer;

        public Statement(Customer customer)
        {
            this.customer = customer;
        }

        public abstract String Print();

        protected String ToString(String newLineDelim, String tabDelim)
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            String result = "Rental Record for " + customer.Name + newLineDelim;

            foreach (var rental in customer.Rentals)
            {
                var thisAmount = rental.Price;
                frequentRenterPoints += rental.FrequentRenterPoints;

                result += tabDelim + rental.Movie.Title + tabDelim
                                    + String.Format("{0:F1}", thisAmount) + newLineDelim;
                totalAmount += thisAmount;
            }

            result += "You owed " + String.Format("{0:F1}", totalAmount) + newLineDelim;
            result += "You earned " + frequentRenterPoints + " frequent renter points" + newLineDelim;

            return result;
        }
    }
}
