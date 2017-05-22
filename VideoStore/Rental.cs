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

        public Rental(Movie movie, Int32 daysRented)
        {
            Movie = movie;
            DaysRented = daysRented;
            Price = CalculatePrice();
            FrequentRenterPoints = CalculateFrequentRenterPoints();
        }

        private Double CalculatePrice()
        {
            double thisAmount = 0;

            switch (Movie.PriceCode)
            {
                case MoviePriceCode.Regular:
                    thisAmount += 2;
                    if (DaysRented > 2)
                        thisAmount += (DaysRented - 2) * 1.5;
                    break;
                case MoviePriceCode.NewRelease:
                    thisAmount += DaysRented * 3;
                    break;
                case MoviePriceCode.Childrens:
                    thisAmount += 1.5;
                    if (DaysRented > 3)
                        thisAmount += (DaysRented - 3) * 1.5;
                    break;
            }

            return thisAmount;
        }

        private Int32 CalculateFrequentRenterPoints()
        {
            var givesBonusFrequentRenterPoint = Movie.PriceCode == MoviePriceCode.NewRelease && DaysRented > 1;

            return givesBonusFrequentRenterPoint ? 2 : 1;
        }
    }
}
