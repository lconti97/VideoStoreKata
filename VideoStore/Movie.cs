using System;

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
