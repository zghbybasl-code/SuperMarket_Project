using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {




                if (    string.IsNullOrWhiteSpace(TxtUserName.Text) || string.IsNullOrWhiteSpace(textBox2.Text)) 
                {


                    MessageBox.Show("Please enter all Fields","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                return;
                }

                else if (TxtUserName.Text == "Basil" && textBox2.Text =="225104208")
                    
                {

                    Market f3 = new Market();
                    f3.Show();
                    this.Hide();


                }

                else if (TxtUserName.Text == "Ahmed" && textBox2.Text == "225100182")
                {
                    Market f2 = new Market();
                    f2.Show();
                    this.Hide();

                }
            else if (TxtUserName.Text == "1" && textBox2.Text == "1")
            {
                Market f2 = new Market();
                f2.Show();
                this.Hide();

            }


            else
                {
                    MessageBox.Show("Invaled UserName or Passward");

                }

            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TxtUserName.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
        
    


