using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_Project
{
    public partial class Market: Form
    {
        public Market()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order f1 = new Order();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer f2= new Customer();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products f1= new Products();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inventory f6= new Inventory();
            f6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dachboard f7= new Dachboard();
            f7 .Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Support f8= new Support();
            f8 .Show();
        }
    }
}
