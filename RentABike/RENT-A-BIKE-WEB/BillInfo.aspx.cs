using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RENT_A_BIKE_WEB
{
    public partial class BillInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int cbase = 0;
            int sbase = 500;
            string child = Request.QueryString["children"];
            string adult = Request.QueryString["adults"];
            string hour = Request.QueryString["hours"];
            int totalprice = 0;
            children.InnerText = "Children: " + child;
            adults.InnerText = "Adults: " + adult;
            date.InnerText = "Date :" + DateTime.Now.ToShortDateString();
            hours.InnerText = "Hours: " + hour;
            if (Request.QueryString["type"] == "10")
            {
                totalprice = (cbase + (Convert.ToInt32(hour) * 100));
                type.InnerText = "Type: Bicycle";
            }
            if (Request.QueryString["type"] == "15")
            {
                totalprice = (sbase + (Convert.ToInt32(hour) * 100));
                type.InnerText = "Type: Scooter";
            }
            if (Request.QueryString["type"] == "20")
            {
                totalprice = (cbase + (Convert.ToInt32(hour) * 100) + sbase + (Convert.ToInt32(hour)));
                type.InnerText = "Type: Bicycle and Scooter";
            }
            totalp.InnerText = "Total price: " + (totalprice * Convert.ToInt32(adult) + (totalprice * Convert.ToInt32(child) * 0.7));

        }

        protected void checkout_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }
}