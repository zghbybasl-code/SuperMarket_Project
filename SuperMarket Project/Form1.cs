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
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text)) {
            if (string.IsNullOrWhiteSpace(textBox1.Text )|| string.IsNullOrWhiteSpace(textBox2.Text)){
             
            
                MessageBox.Show("Error please Enter a Name or Password");


            }
            else if (textBox1.Text == "Basil" && textBox2.Text == "225104208")
            else if (textBox1.Text=="Basil" && textBox2.Text=="225104208")
            {
                Form2 f3 = new Form2();
               Form2 f3=new Form2();
                f3.Show();
                this.Hide();


            }
            else if (textBox1.Text == "Ahmed" && textBox2.Text == "225100182")
            {

                Form2 f2= new Form2();
                f2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invaled UserName or Passward");

            }
            
        }
    }
}
