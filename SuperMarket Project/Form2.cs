using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMarket_Project
{
    public partial class Market : Form
    {
        public Market()
        {
            InitializeComponent();
        }

        // زرار فتح الأوردر
        private void button1_Click(object sender, EventArgs e)
        {
            Order f1 = new Order();
            f1.Show();
            // تأكد إن عندك زرار فعلاً اسمه BtnOrder في الديزاينر
            // لو طلع خط أحمر امسح السطر اللي تحت ده
            // BtnOrder.BackColor = Color.SkyBlue; 
        }

        // زرار الكاستمر (كان button4)
        private void button4_Click(object sender, EventArgs e)
        {
            Customer f2 = new Customer();
            f2.Show();
        }

        // زرار الوجبات (Meals)
        private void button2_Click(object sender, EventArgs e)
        {
            Meals f7 = new Meals();
            f7.Show();
        }

        // زرار السبورت (Support)
        private void button6_Click(object sender, EventArgs e)
        {
            Support f8 = new Support();
            f8.Show();
        }

        // زرار الخروج
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // الأماكن الفاضية اللي ممكن تمسحها لو عاملة Error
        private void label1_Click(object sender, EventArgs e) { }
        private void Button3_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void Market_Load(object sender, EventArgs e) { }
    }
}