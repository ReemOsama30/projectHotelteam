using HotelProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projectHotel
{
    public partial class ReservationDetails : Form
    {
        public ReservationDetails()
        {
            InitializeComponent();
        }

        private void ReservationDetails_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Repo roomtypesdeatils = new Repo();
           roomtypesdeatils.Database.EnsureCreated();
            RoomType roomTypes = new RoomType();
            dataGridView1.DataSource = roomtypesdeatils.roomTypes.ToList();

        }
    }
}
