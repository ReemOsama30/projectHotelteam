using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelProject
{
    public partial class Reserve_Rooms : Form
    {
        
        public Reserve_Rooms()
        {
         
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Repo repo = new Repo();
            string name = txtName.Text;
            string phone = txtPhone.Text;


            client cl = (from c in repo.clients.ToList()
                         where c.Name == name && c.Phone_Number == phone
                         select c).FirstOrDefault();


            Booking book = new Booking();
            Room room = new Room();
            if (textBox3.Text.Length > 0)
            {
                book.Number_Of_Days = int.Parse(textBox3.Text);
                book.Room_ID = int.Parse(textBox4.Text);
                book.client_ID = cl.ID;
            
                repo.Database.EnsureCreated();


                Room rr = (from g in repo.rooms.ToList()
                           where g.ID == book.Room_ID
                           select g).FirstOrDefault();

                RoomType t = (from c in repo.roomTypes.ToList()
                              where c.ID == rr.RoomTypeID
                              select c).FirstOrDefault();

                if (rr != null)
                {
                    if (rr.isReserved)
                    {
                        MessageBox.Show("Already Reserved");
                    }
                    else
                    {
                        rr.isReserved = true;
                        repo.rooms.Update(rr);
                        repo.SaveChanges();

                        repo.bookings.Add(book);
                        MessageBox.Show("Done");

                    }

                }

                dataGridView1.DataSource = repo.bookings.ToList();
                repo.SaveChanges();
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter Data");
            }
        }

    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reserve_Rooms_Load(object sender, EventArgs e)
        { 
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
