using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public class Customer
    {
        public String Name { get; private set; }
        private List<Rental> rentals = new List<Rental>();

        public Customer(String name)
        {
            Name = name;
        }

        public void AddRental(Rental rental)
        {
            rentals.Insert(0, rental);
        }

        public String Statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            String result = "Rental Record for " + Name + "\n";

            foreach (var rental in rentals)
            {
                var thisAmount = rental.Price;
                frequentRenterPoints += rental.FrequentRenterPoints;

                result += "\t" + rental.Movie.Title + "\t"
                                    + String.Format("{0:F1}", thisAmount) + "\n";
                totalAmount += thisAmount;
            }

            result += "You owed " + String.Format("{0:F1}", totalAmount) + "\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points\n";

            return result;
        }
    }
}
