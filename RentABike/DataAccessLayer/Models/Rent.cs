using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Rent
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public decimal Rental_price { get; set; }
        public DateTime Rental_date { get; set; }
        public DateTime Rental_time { get; set; }
    }
}
