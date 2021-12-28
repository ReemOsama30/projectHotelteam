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
    public partial class Client_Feature : Form
    {
        public Client_Feature()
        {
            InitializeComponent();
        }

        private void Client_Feature_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ReservationDetails reservationDetails = new ReservationDetails();
            reservationDetails.Show();
            Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AboutOurHotel aboutOurHotel = new AboutOurHotel();
            aboutOurHotel.Show();
            Hide();
        }
    }
}
