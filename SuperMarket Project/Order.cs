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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

   

     

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(CmbProduct.Text)|| string.IsNullOrWhiteSpace(TxtCount.Text)|| string.IsNullOrWhiteSpace(TxtID.Text) || string.IsNullOrWhiteSpace(TxtPrice.Text))
            {

                MessageBox.Show("Error Pls Enter ID Product or Count Product Or Choose The Prouduct ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DgvOrders.Rows.Add(CmbProduct.Text,TxtID,TxtCount.Text,TxtPrice);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text) || string.IsNullOrWhiteSpace(CmbSite.Text))
            {

                MessageBox.Show("Error Pls Enter a Name or this Site", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            DgvOrders.Rows.Add(TxtName.Text, CmbSite.Text);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DgvOrders.Rows.Clear();
        }

        private void CmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

            CmbProduct.Items.Add("Burger");
            CmbProduct.Items.Add("Pizza");
            CmbProduct.Items.Add("Shawarma");
            CmbProduct.Items.Add("Potato and Cheese Sandwich");
            CmbProduct.Items.Add("Macaroni Bechamel");
            CmbProduct.Items.Add("Chicken Crepe");
            CmbProduct.SelectedIndex = 0;
        }

        private void CmbSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbSite.Items.Add("Naser City");
            CmbSite.Items.Add("Maady");
            CmbSite.Items.Add("New Cairo");
            CmbSite.Items.Add("Sheikh Zayed");
            CmbSite.Items.Add("Dokki");
            CmbSite.Items.Add("New Damietta");
            CmbSite.SelectedIndex= 0;
        }
    }
}
