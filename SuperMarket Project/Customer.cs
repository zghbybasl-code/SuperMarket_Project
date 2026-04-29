using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_Project
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter Customer Name and Phone Number.",
                "Input Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            dgvCustomers.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.None;
           

            //File Handleing
            CustomerLogic s3 = new CustomerLogic();
            s3.Name = txtName.Text;
            s3.Phone = txtPhone.Text;
            s3.savefile();



            dgvCustomers.Rows.Add(txtName.Text, txtPhone.Text);

            txtName.Clear();
            txtPhone.Clear();
            txtName.Focus();

            MessageBox.Show("Customer added successfully.", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            CustomerLogic.LoadFile(dgvCustomers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Customer.Txt",string.Empty);
            dgvCustomers.Rows.Clear();

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
public class CustomerLogic
{
    public string Name { get; set; }
    public string Phone { get; set; }

    public void savefile()
    {


        using (StreamWriter Writer = new StreamWriter("Customer.Txt", true))

            Writer.WriteLine($"{Name}|{Phone}");



    }












    public static void LoadFile(DataGridView DgvCustomers)
    {


        if (File.Exists("Customer.Txt"))
        {
            string[] Rows = File.ReadAllLines("Customer.Txt");
            foreach (string s in Rows)
            {


                string[] data3 = s.Split('|');
                DgvCustomers.Rows.Add(data3);


            }

           



        }



    }








}




















