using BusinessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RENT_A_BIKE_WEB
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_ServerClick(object sender, EventArgs e)
        {
            RentBusiness rb = new RentBusiness();
            User u = new User();
            u.Name = username.Value;
            u.Surname = Surname.Value;
            u.Password = password.Value;
            u.Telephone = Phone.Value;
            u.Email = email.Value;
            rb.InserUser(u);
            Response.Redirect("Main.aspx");
        }
    }
}