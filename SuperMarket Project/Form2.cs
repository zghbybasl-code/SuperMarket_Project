using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace SuperMarket_Project
{
    public partial class Market: Form
    {
        public Market() => InitializeComponent();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order f1 = new Order();
            f1.Show();

            BtnOrder.BackColor = Color.SkyBlue;


            Cursor = Cursors.Default;
        }


        

        private void button4_Click(object sender, EventArgs e)
        {
            Customer f2= new Customer();
            f2.Show();
            BtnOrder.BackColor = Color.SkyBlue;
            Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Meals f7 = new Meals();
            f7.Show();
            BtnOrder.BackColor = Color.SkyBlue;
            Cursor = Cursors.Default;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            Support f8= new Support();
            f8 .Show();
            BtnOrder.BackColor = Color.SkyBlue;
            Cursor = Cursors.Default;
        }

        public void Market_Load(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Are you sure you want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            this.Close();
            Application.Exit();
            BtnOrder.BackColor = Color.DarkRed;
            Cursor = Cursors.Default;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     
            
        


    }
}
