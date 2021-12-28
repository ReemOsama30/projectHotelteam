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
    public partial class AboutOurHotel : Form
    {
        public AboutOurHotel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Client_Feature clientfeatures = new Client_Feature();
            clientfeatures.Show();
            Hide();

        }
    }
}

      