using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RENT_A_BIKE_WEB
{
    public partial class Main : System.Web.UI.Page
    {
        List<RentPrice> rentPrices;

        protected void Page_Load(object sender, EventArgs e)
        {
            rentPrices = new List<RentPrice>();
            rentPrices.Add(new RentPrice(100, "1 h", "Bicycle", " "));
            rentPrices.Add(new RentPrice(200, "2 h", "Bicycle", " "));
            rentPrices.Add(new RentPrice(300, "3 h", "Bicycle", " "));
            rentPrices.Add(new RentPrice(400, "4 h", "Bicycle", " "));
            rentPrices.Add(new RentPrice(500, "5 h", "Bicycle", " "));

            rentPrices.Add(new RentPrice(600, "1 h", " ", "Scooter"));
            rentPrices.Add(new RentPrice(700, "2 h", " ", "Scooter"));
            rentPrices.Add(new RentPrice(800, "3 h", " ", "Scooter"));
            rentPrices.Add(new RentPrice(900, "4 h", " ", "Scooter"));
            rentPrices.Add(new RentPrice(1000, "5 h", " ", "Scooter"));

            rentPrices.Add(new RentPrice(700, "1 h", "Bicycle", "Scooter"));
            rentPrices.Add(new RentPrice(900, "2 h", "Bicycle", "Scooter"));
            rentPrices.Add(new RentPrice(1100, "3 h", "Bicycle", "Scooter"));
            rentPrices.Add(new RentPrice(1300, "4 h", "Bicycle", "Scooter"));
            rentPrices.Add(new RentPrice(1500, "5 h", "Bicycle", "Scooter"));

        }

   
        protected void sumbitbtn_ServerClick(object sender, EventArgs e)
        {
            int chc = 0;
            if (Bicyclec.Checked == true)
                chc = 10;
            if (Scooterc.Checked == true)
                chc = 15;

                if (Scooterc.Checked == true && Bicyclec.Checked == true)
                chc = 20;

            Response.Redirect($"Billinfo.aspx?adults={adultnum.Value}&children={childrennum.Value}&type={chc}&hours={hours.Value}");
        }
    }
}