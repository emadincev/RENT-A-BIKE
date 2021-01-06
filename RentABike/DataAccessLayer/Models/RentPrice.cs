using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class RentPrice
    {
        public double Price { get; set; }
        public string Hours { get; set; }
        public string Bicycle { get; set; }
        public string Scooter { get; set; }

        public RentPrice(double price, string hours, string bicycle, string scooter)
        {
            Price = price;
            Hours = hours;
            Bicycle = bicycle;
            Scooter = scooter;
        }
    }
}
