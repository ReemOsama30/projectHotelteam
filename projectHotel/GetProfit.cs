using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using HotelProject;

namespace projectHotel
{
    public partial class GetProfit : Form
    {
        public GetProfit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Repo repo = new Repo();


 var list = repo.bookings.ToList();
        var  profit = (from c in repo.bookings.ToList()
                            where c.isFinish == true
                             select c).ToList();
            double totalProfit = 0;
            for (int i = 0; i < profit.Count(); i++)
            {
                
                    totalProfit += profit.ElementAt(i).TotalPrice;
                
            }
            textBox1.Text = totalProfit.ToString();

        }
    }
}
