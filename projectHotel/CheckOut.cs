using HotelProject;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectHotel
{
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int RroomID = int.Parse(textBox5.Text);
          
            string name = textBox1.Text;
            string phone = textBox3.Text;


            Repo r = new Repo();
            Booking book = new Booking();

            Room rr = (from g in r.rooms.ToList()
                       where g.ID == RroomID
                       select g).FirstOrDefault();

            rr = (from g in r.rooms.ToList()
                  where g.ID == RroomID
                  select g).FirstOrDefault();

            RoomType t = (from c in r.roomTypes.ToList()
                          where c.ID == rr.RoomTypeID
                          select c).FirstOrDefault();

            var list = r.bookings.ToList();

            Booking b = (from c in r.bookings.ToList()
                         where c.Room_ID == RroomID
                         select c).FirstOrDefault();

            var users = r.clients.ToList();
            client cl = (from c in r.clients.ToList()
                         where c.Name == name && c.Phone_Number == phone
                         select c).FirstOrDefault();

            if (b.client_ID == cl.ID)
            {
                double price = t.price_Per_Night * b.Number_Of_Days;
                textBox4.Text = price.ToString();
                b.isFinish = true;
                b.TotalPrice = price;

                if (rr != null)
                {
                    if (rr.isReserved)
                    {
                        rr.isReserved = false;
                        r.Update(rr);
                        r.SaveChanges();
                        MessageBox.Show("Done");
                    }
                    else
                    MessageBox.Show(" Already Empty");
                }
            }
            else
            {
                MessageBox.Show("Invalid Client Id");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            int RroomID = int.Parse(textBox5.Text);
            Booking book = new Booking();
            Room room = new Room();
            Repo repo = new Repo();
            Room rr = (from g in repo.rooms.ToList()
                       where g.ID == RroomID
                       select g).FirstOrDefault();

            RoomType t = (from c in repo.roomTypes.ToList()
                          where c.ID == rr.RoomTypeID
                          select c).FirstOrDefault();
            Booking b = (from c in repo.bookings.ToList()
                         where c.Room_ID == RroomID
                         select c).LastOrDefault();
            double price = t.price_Per_Night * b.Number_Of_Days;



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}