using BusinessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentABike
{
    public partial class Login : Form
    {
        private RentBusiness rentBusiness;

        public Login()
        {
            InitializeComponent();
            rentBusiness = new RentBusiness();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Email = textBoxEmail.Text;
            u.Password = textBoxPassword.Text;
            bool result = this.rentBusiness.CheckUser(u);

            if(result)
            {
                Rent r = new Rent();
                r.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong entry!");
                textBoxEmail.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.ShowDialog();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '●';
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            User d = new User();
            d.Email = textBoxEmail.Text;
            bool delete = this.rentBusiness.DeleteUser(d);
            if(delete)
            {
                List<User> users = this.rentBusiness.GetAllUsers();
                MessageBox.Show("Successfully delete user!");
                textBoxEmail.Text = "";
                Application.Exit();
            }
            else
            {
                MessageBox.Show("You could not delete the user!");
            }
        }
    }
}
