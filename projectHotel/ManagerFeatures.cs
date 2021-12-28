using HotelProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectHotel
{
    public partial class ManagerFeatures : Form
    {
        public ManagerFeatures()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
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
            ReservationDetails reserveDetails = new ReservationDetails();
            reserveDetails.Show();
            Hide();
        }
    }
}
