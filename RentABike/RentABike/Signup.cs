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
    public partial class Signup : Form
    {
        private RentBusiness rentBusiness = new RentBusiness();

        public Signup()
        {
            InitializeComponent();
            rentBusiness = new RentBusiness();
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Name = textBoxName.Text;
            u.Surname = textBoxSurname.Text;
            u.Address = textBoxAddress.Text;
            u.Telephone = textBoxTelephone.Text;
            u.Email = textBoxEmail.Text;
            u.Password = textBoxPassword.Text;

            if(this.rentBusiness.InserUser(u))
            {
                List<User> users = this.rentBusiness.GetAllUsers();
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxAddress.Text = "";
                textBoxTelephone.Text = "";
                textBoxEmail.Text = "";
                textBoxPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Incorrectly entered data!");
            }

            Rent r = new Rent();
            r.ShowDialog();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '●';
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            User up = new User();
            up.Name = textBoxName.Text;
            up.Surname = textBoxSurname.Text;
            up.Address = textBoxAddress.Text;
            up.Telephone = textBoxTelephone.Text;
            up.Email = textBoxEmail.Text;
            up.Password = textBoxPassword.Text;

            bool update = this.rentBusiness.UpdateUser(up);
            if(update)
            {
                MessageBox.Show("Successful update!");
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxAddress.Text = "";
                textBoxTelephone.Text = "";
                textBoxEmail.Text = "";
                textBoxPassword.Text = "";

                Login l = new Login();
                l.ShowDialog();
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }
    }
}
