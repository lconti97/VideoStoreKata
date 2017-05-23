using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public class RentalPriceCalculator
    {
        public static Double Calculate(MoviePriceCode priceCode, Int32 daysRented)
        {
            double price = 0;

            switch (priceCode)
            {
                case MoviePriceCode.Regular:
                    price += 2;
                    if (daysRented > 2)
                        price += (daysRented - 2) * 1.5;
                    break;
                case MoviePriceCode.NewRelease:
                    price += daysRented * 3;
                    break;
                case MoviePriceCode.Childrens:
                    price += 1.5;
                    if (daysRented > 3)
                        price += (daysRented - 3) * 1.5;
                    break;
            }

            return price;
        }
    }
}
