using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using projectHotel;

namespace HotelProject
{
    public partial class ManagerSignUp : Form
    {
        public ManagerSignUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            Hide();
        }

        private void ManagerSignUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Repo db = new Repo();
                 bool b = db.Database.EnsureCreated();
            string name = textBox1.Text;
            int id = int.Parse(textBox2.Text);
            Manager m = (from c in db.managers.ToList()
                         where c.Name == name && c.ID == id
                         select c).FirstOrDefault();
            if (m == null)
            {
                MessageBox.Show("Login Faild");
            }
            else
            {
                ManagerFeatures managerFeatures = new ManagerFeatures();
                managerFeatures.Show();
                Hide();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
