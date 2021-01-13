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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void log_ServerClick(object sender, EventArgs e)
        {
            RentBusiness rb = new RentBusiness();
            User u;
            try
            {
                u = (from user in rb.GetAllUsers() where user.Email == username.Value && user.Password == password.Value select user).First();
            }
            catch
            {
                u = null;
            }
            if (u != null)
                Response.Redirect("Main.aspx");
        }
    }
}