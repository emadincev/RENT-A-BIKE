using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentABikeWeb
{
    public partial class Information : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            date.InnerText = DateTime.Now.ToLongDateString();
            time.InnerText = DateTime.Now.ToShortTimeString();
            type.InnerText = "Omae wa mou shindeiru";
            price.InnerText = "NANI";
        }

        protected void rent_ServerClick(object sender, EventArgs e)
        {

        }
    }
}