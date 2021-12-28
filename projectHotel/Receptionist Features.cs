using projectHotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelProject
{
    public partial class Receptionist_Features : Form
    {
        public Receptionist_Features()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutRooms aboutRooms = new AboutRooms();
            aboutRooms.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientData clientData = new clientData();
            clientData.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckOut checkout = new CheckOut();
            checkout.Show();
            Hide();
        }
    }
}
