﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public class Rental
    {
        public Rental(Movie movie, int daysRented)
        {
            this.movie = movie;
            this.daysRented = daysRented;
        }

        public int getDaysRented()
        {
            return daysRented;
        }

        public Movie getMovie()
        {
            return movie;
        }

        private Movie movie;
        private int daysRented;
    }
}