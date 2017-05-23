using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore.Factories
{
    public static class RentalFactory
    {       
        public static Rental CreateRental(Movie movie, Int32 daysRented)
        {
            var price = RentalPriceCalculator.Calculate(movie.PriceCode, daysRented);
            var frequentRenterPoints = FrequentRentalPointsCalculator.Calculate(movie.PriceCode, daysRented);
            return new Rental(movie, daysRented, price, frequentRenterPoints);
        }
    }
}
