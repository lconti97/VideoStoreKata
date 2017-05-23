using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class FrequentRentalPointsCalculator
    {
        public static Int32 Calculate(MoviePriceCode priceCode, Int32 daysRented)
        {
            var givesBonusFrequentRenterPoint = priceCode == MoviePriceCode.NewRelease && daysRented > 1;

            return givesBonusFrequentRenterPoint ? 2 : 1;
        }
    }
}
