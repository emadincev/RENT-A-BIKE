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
    public partial class SumOfInformations : Form
    {
        private RentBusiness rentBusiness = new RentBusiness();

        public SumOfInformations(double totalPrice, bool isBicycle, bool isScooter, MonthCalendar monthCalendarDateRent, DateTime dateTime)
        {
            InitializeComponent();
            rentBusiness = new RentBusiness();
            labelTotal.Text = totalPrice.ToString() + " RSD";
            labelDate.Text = monthCalendarDateRent.SelectionRange.Start.ToShortDateString();
            labelSelectedTime.Text = DateTime.Now.ToShortTimeString();

            if(isBicycle == true && isScooter == false)
            {
                labelType.Text = "Bicycle";
            }
            else if(isBicycle == false && isScooter == true)
            {
                labelType.Text = "Scooter";
            }
            else if(isBicycle == true && isScooter == true)
            {
                labelType.Text = "Bicycle and Scooter";
            }
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Type = labelType.Text;
            bool product = this.rentBusiness.InsertProduct(p);
            if(product)
            {
                MessageBox.Show("You have successfully rented a bicycle / scooter!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
