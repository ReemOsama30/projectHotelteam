using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelProject
{
    public partial class ReceptionistSignUp : Form
    {
        public ReceptionistSignUp()
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
            if (textBox2.Text.Length > 0)
            {
                int id = int.Parse(textBox2.Text);
                Receptionist R = (from c in db.receptionists.ToList()
                                  where c.ID == id && c.Name == name
                                  select c).FirstOrDefault();
                if (R == null)
                {
                    MessageBox.Show("Login Faild");
                }
                else
                {

                    Receptionist_Features receptionistFeature = new Receptionist_Features();
                    receptionistFeature.Show();
                    Hide();

                }

            }
            else
            {
                MessageBox.Show("Please Input data");

            }



        }

        private void ReceptionistSignUp_Load(object sender, EventArgs e)
        {
            button3.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == (char)0)
            {
                textBox2.PasswordChar = '*';
            }
            else
            {
                textBox2.PasswordChar = (char)0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text.Length>0)
            {
                button3.Show();
            }
            else
            {
                button3.Hide();
            }
        }
    }
}
