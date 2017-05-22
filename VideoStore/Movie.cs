using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public class Movie
    {

        public String Title { get; private set; }
        public MoviePriceCode PriceCode { get; private set; }

        public Movie(String title, MoviePriceCode priceCode)
        {
            Title = title;
            PriceCode = priceCode;
        }

    }
    public enum MoviePriceCode
    {
        Regular,
        Childrens,
        NewRelease
    }

}
