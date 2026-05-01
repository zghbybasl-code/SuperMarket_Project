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
    public partial class Menu : Form
    {
        int total = 0;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }


        //hjhjhjhj



        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void buttonburger_Click(object sender, EventArgs e)

        {
            listBox2.Items.Add("برجر - 145 EGP");
            total += 145;
            labelTotal.Text = "Total: " + total + " EGP";
        }

        private void buttonPasta_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("باستا - 180 EGP");
            total += 180;
            labelTotal.Text = "Total: " + total + " EGP";
        }

        private void buttonPizza_Click_1(object sender, EventArgs e)

        {
            listBox2.Items.Add("بيتزا -  120 EGP");
            total = total + 120;
            labelTotal.Text = "Total: " + total + " EGP";
        }
        private void buttonDesert_Click(object sender, EventArgs e)

        {
            listBox2.Items.Add("تشيز كيك - 110 EGP");
            total += 110;
            labelTotal.Text = "Total: " + total + " EGP";
        }




        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOrder_Click(object sender, EventArgs e)


        {
            if (total > 0)
            {
                MessageBox.Show("تم تأكيد الطلب بنجاح! الحساب الإجمالي: " + total + " جنيه");

                // تنظيف السلة والحساب بعد الطلب
                listBox2.Items.Clear();
                total = 0;

                // ارجعي اكتبي اسم الليبل بتاعك هنا عشان يرجع 0
                labelTotal.Text = "Total: 0 EGP";
            }
            else
            {
                MessageBox.Show("من فضلك أضف وجبات للسلة أولاً!");
            }
        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonmoltencake_Click(object sender, EventArgs e)
        {
        
        }
    }
}

       



       
    




    

    
    

