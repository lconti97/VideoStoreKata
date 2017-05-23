using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public class Customer
    {
        public String Name { get; private set; }
        public List<Rental> Rentals { get; private set; }

        public Customer(String name)
        {
            Name = name;
            Rentals = new List<Rental>();
        }

        public void AddRental(Rental rental)
        {
            Rentals.Insert(0, rental);
        }
    }
}
