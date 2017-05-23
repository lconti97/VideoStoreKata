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
            double price = 0;

            switch (Movie.PriceCode)
            {
                case MoviePriceCode.Regular:
                    price += 2;
                    if (DaysRented > 2)
                        price += (DaysRented - 2) * 1.5;
                    break;
                case MoviePriceCode.NewRelease:
                    price += DaysRented * 3;
                    break;
                case MoviePriceCode.Childrens:
                    price += 1.5;
                    if (DaysRented > 3)
                        price += (DaysRented - 3) * 1.5;
                    break;
            }

            return price;
        }

        private Int32 CalculateFrequentRenterPoints()
        {
            var givesBonusFrequentRenterPoint = Movie.PriceCode == MoviePriceCode.NewRelease && DaysRented > 1;

            return givesBonusFrequentRenterPoint ? 2 : 1;
        }
    }
}
