using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
        
    {
        int total = 0;

        public Form1()

        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        



        {
            listBox2.Items.Add("Pizza - 120 EGP");
            total = total + 120;
            labelTotal.Text = "Total: " + total + " EGP";
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonburger_Click(object sender, EventArgs e)
        {
           
        {
            listBox2.Items.Add("برجر - 145 EGP");
            total += 145;
            labelTotal.Text = "Total: " + total + " EGP";
        }
    }

        private void buttonpasta_Click(object sender, EventArgs e)
        
            
        {
            listBox2.Items.Add("باستا - 180 EGP");
            total += 180;
            labelTotal.Text = "Total: " + total + " EGP";
        }

        private void buttondesert_Click(object sender, EventArgs e)
        
            
        {
            listBox2.Items.Add("تشيز كيك - 110 EGP");
            total += 110;
            labelTotal.Text = "Total: " + total + " EGP";
        }

        


        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (total > 0)
            {
                MessageBox.Show("تم طلب الأوردر بنجاح! الإجمالي: " + total + " جنيه");
                // تفريغ السلة بعد الطلب
                listBox2.Items.Clear();
                total = 0;
                labelTotal.Text = "Total: 0 EGP";
            }
            else
            {
                MessageBox.Show("من فضلك اختر وجبة أولاً!");
            }
        }

        
            private void buttonOrderNow_Click(object sender, EventArgs e)
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

        private void btnorder_Click(object sender, EventArgs e)
            //test update
        
            
        {
            // 1. التأكد إن فيه أكل في السلة (ListBox) قبل ما نطلع الرسالة
            if (total > 0)
            {
                // 2. إظهار رسالة النجاح Successful
                MessageBox.Show("Successful! Your order has been placed.");

                // 3. مسح الأصناف من المربع الأبيض (ListBox)
                listBox2.Items.Clear();

                // 4. تصفير الحساب الإجمالي
                total = 0;

                // 5. تحديث الليبل عشان يرجع يكتب Total: 0 EGP
                labelTotal.Text = "Total: 0 EGP";
            }
            else
            {
                // رسالة تنبيه لو السلة فاضية
                MessageBox.Show("Please add some items to your order first!");
            }

        }
    }
    }
    
    
    
    
