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
    public partial class clientData : Form
    {
        public clientData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                Repo clientData = new Repo();
                client clientss = new client();
                clientss.Name = textBox1.Text;
                clientss.Phone_Number = textBox3.Text;
                clientData.Database.EnsureCreated();
                clientData.clients.Add(clientss);
                clientData.SaveChanges();
                Reserve_Rooms reserve_Rooms = new Reserve_Rooms();
                reserve_Rooms.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(" Enter Data");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Receptionist_Features receptionist_Features = new Receptionist_Features();
            receptionist_Features.Show();
            Hide();
        }
    }
}
