using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            else if (string.IsNullOrWhiteSpace(TxtName.Text) || string.IsNullOrWhiteSpace(CmbSite.Text))
            {

                MessageBox.Show("Error Pls Enter a Name or this Site", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            string Name = TxtName.Text;
            string Site=CmbSite.Text.ToString();
            string Products=CmbProduct.Text.ToString();
            string ID = TxtID.Text;
            string Count=TxtCount.Text;
            string Price=TxtPrice.Text;
            DgvOrders.Rows.Add(Name,Site,Products,ID,Count,Price);
            MessageBox.Show("The Order Added Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtName.Clear();
            TxtCount.Clear();
            TxtPrice.Clear();
            TxtID.Clear();
            TxtName.Focus();
            

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
            CmbProduct.SelectedIndex = 0;


        }
 



        private void CmbSite_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            CmbSite.SelectedIndex= 0;
        }
       
    }
}
