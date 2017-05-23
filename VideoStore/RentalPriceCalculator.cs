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
            Double basePrice = 0;
            Double additionalChargeRate = 0;
            Int32 daysForAdditionalCharge = 0;
            switch (priceCode)
            {
                case MoviePriceCode.Regular:
                    basePrice = 2;
                    additionalChargeRate = 1.5;
                    daysForAdditionalCharge = 2;
                    break;
                case MoviePriceCode.NewRelease:
                    basePrice = 0;
                    additionalChargeRate = 3;
                    daysForAdditionalCharge = 0;
                    break;
                case MoviePriceCode.Childrens:
                    basePrice = 1.5;
                    additionalChargeRate = 1.5;
                    daysForAdditionalCharge = 3;
                    break;
            }

            double price = basePrice;
            if (daysRented > daysForAdditionalCharge)
                price += (daysRented - daysForAdditionalCharge) * additionalChargeRate;

            return price;
        }
    }
}
