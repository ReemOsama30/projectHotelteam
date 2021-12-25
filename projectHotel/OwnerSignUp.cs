using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using projectHotel;

namespace HotelProject
{
    public partial class OwnerSignUp : Form
    {
        public OwnerSignUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Repo db = new Repo();
            bool b = db.Database.EnsureCreated();
            string name = textBox1.Text;
            int id = int.Parse(textBox2.Text);
            Owner o= (from c in db.owners.ToList()
                         where c.Name == name && c.ID == id
                         select c).FirstOrDefault();
            if (o == null)
            {
                MessageBox.Show("Login Faild");
            }
            else
            {
                OwnerFeatures ownerFeatures = new OwnerFeatures();
                ownerFeatures.Show();
                Hide();

            }
        }
    }
}
