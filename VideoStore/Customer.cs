using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public class Customer
    {
        public Customer(String name)
        {
            this.name = name;
        }

        public void AddRental(Rental rental)
        {
            rentals.Insert(0, rental);
        }

        public String GetName()
        {
            return name;
        }

        public String statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            String result = "Rental Record for " + GetName() + "\n";
           

            foreach (var rental in rentals)
            {
                double thisAmount = 0;

                // determines the amount for each line
                switch (rental.getMovie().getPriceCode())
                {
                    case Movie.REGULAR:
                        thisAmount += 2;
                        if (rental.getDaysRented() > 2)
                            thisAmount += (rental.getDaysRented() - 2) * 1.5;
                        break;
                    case Movie.NEW_RELEASE:
                        thisAmount += rental.getDaysRented() * 3;
                        break;
                    case Movie.CHILDRENS:
                        thisAmount += 1.5;
                        if (rental.getDaysRented() > 3)
                            thisAmount += (rental.getDaysRented() - 3) * 1.5;
                        break;
                }

                frequentRenterPoints++;

                if (rental.getMovie().getPriceCode() == Movie.NEW_RELEASE
                        && rental.getDaysRented() > 1)
                    frequentRenterPoints++;

                result += "\t" + rental.getMovie().getTitle() + "\t"
                                    + String.Format("{0:F1}", thisAmount) + "\n";
                totalAmount += thisAmount;

            }

            result += "You owed " + String.Format("{0:F1}", totalAmount) + "\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points\n";


            return result;
        }


        private String name;
        private List<Rental> rentals = new List<Rental>();
    }
}
