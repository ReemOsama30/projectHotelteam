using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelProject
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        

        


        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }


     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Client_Feature clientFeatures = new Client_Feature();
            clientFeatures.Show();
            Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            ReceptionistSignUp receptionists = new ReceptionistSignUp();
            receptionists.Show();
            Hide();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            ManagerSignUp managers = new ManagerSignUp();
            managers.Show();
            Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OwnerSignUp owners = new OwnerSignUp();
            owners.Show();
            Hide();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
