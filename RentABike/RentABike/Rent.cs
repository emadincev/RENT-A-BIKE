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
    public partial class Rent : Form
    {
        private readonly RentBusiness rentBusiness;

        double totalPrice = 0;
        private DateTime dateTime;
        List<RentPrice> rentPrices; 

        public Rent()
        {
            InitializeComponent();
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

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Signup sp = new Signup();
            sp.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            monthCalendar.SetDate(DateTime.Now);
            comboBoxHours.ResetText();
            numericUpDownAdult.ResetText();
            numericUpDownChildren.ResetText();
            checkBoxBicycle.Checked = false;
            checkBoxScooter.Checked = false;
            labelCurrentPrice.ResetText();
            labelNewTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Form SumOfInformation = new SumOfInformations(totalPrice, checkBoxBicycle.Checked, checkBoxScooter.Checked, monthCalendar, dateTime);
            SumOfInformation.ShowDialog();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            DateTime selectedDate = monthCalendar.SelectionStart;

            if(selectedDate < currentDate)
            {
                MessageBox.Show("Date of rent must be equal to or greater than the current one!");
            }
        }

        private void buttonPrice_Click(object sender, EventArgs e)
        {
            totalPrice = 0;

            string h = comboBoxHours.Text;
            string b = checkBoxBicycle.Text;
            string s = checkBoxScooter.Text;
            bool b1 = checkBoxBicycle.Checked;
            bool s1 = checkBoxScooter.Checked;

            double price = GetPrice(h, b, s, b1, s1);

            if(checkBoxBicycle.Checked)
            {
                price *= 1;
            }

            if(checkBoxScooter.Checked)
            {
                price *= 1;
            }

            int adultNum = Convert.ToInt32(numericUpDownAdult.Value);
            if(adultNum > 0)
            {
                totalPrice += price * adultNum;
            }

            int childrenNum = Convert.ToInt32(numericUpDownChildren.Value);
            if(childrenNum > 0)
            {
                totalPrice += price * 0.7 * childrenNum;
            }

            labelCurrentPrice.Text = price.ToString() + " RSD";
        }

        private double GetPrice(string h, string b, string s, bool b1, bool s1)
        {
            foreach(RentPrice rp in rentPrices)
            {
                if((rp.Hours == h && (rp.Scooter == s) == s1 && (rp.Bicycle == b) == b1))
                {
                    return rp.Price;
                }
            }
            return 0;
        }

        private void Rent_Load(object sender, EventArgs e)
        {
            labelNewTime.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
