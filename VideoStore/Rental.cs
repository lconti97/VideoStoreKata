using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public class Rental
    {
        public Double Price { get; private set; }
        public Movie Movie { get; private set; }
        public Int32 DaysRented { get; private set; }
        public Int32 FrequentRenterPoints { get; private set; }
        public Rental(Movie movie, Int32 daysRented, Double price, Int32 frequentRenterPoints)
        {
            Movie = movie;
            DaysRented = daysRented;
            Price = price;
            FrequentRenterPoints = frequentRenterPoints;
        }
    }
}
