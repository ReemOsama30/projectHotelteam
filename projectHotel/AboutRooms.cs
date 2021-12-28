using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace HotelProject
{
    public partial class AboutRooms : Form
    {
        public AboutRooms()
        {
            InitializeComponent();
        }

     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Repo roomDetails = new Repo();
            roomDetails.Database.EnsureCreated();
            Room room = new Room();
            RoomType roomTypes = new RoomType();
            dataGridView1.DataSource = roomDetails.rooms.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Reserve_Rooms reserveRoom = new Reserve_Rooms();
            reserveRoom.Show();
            Hide();
        }
    }
}
