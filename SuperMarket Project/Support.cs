using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
namespace SuperMarket_Project
{
    public partial class Support : Form
    {
        public Support()
        {
            InitializeComponent();

        }

        private void Support_Load(object sender, EventArgs e)
        {
            SupportLogic.LoadInfoSupport(dgvSupport);
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {   //file handleing
            SupportLogic s1= new SupportLogic();
            s1.Name2 = txtName.Text;
            s1.CustomerNum= txtCustomerNum.Text;
            s1.Description= txtDescription.Text;
            s1.cmbIssuTybe=cmbIssueTybe.Text;
            s1.savefile();



            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                cmbIssueTybe.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtCustomerNum.Text))
            {
                MessageBox.Show("Please fill in ALL fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvSupport.Rows.Add(txtName.Text, cmbIssueTybe.Text, txtDescription.Text, txtCustomerNum.Text);

            MessageBox.Show("Support request sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtName.Clear();
            cmbIssueTybe.SelectedIndex = -1;
            txtDescription.Clear();
            txtCustomerNum.Clear();
            txtName.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class SupportLogic
        {

            public string Name2 { get; set; }
            public string Description { get; set; }
            public string CustomerNum { get; set; }
            public string cmbIssuTybe { get; set; }
            public void savefile()
            {
                using (StreamWriter Writer = new StreamWriter("Support.Txt", true))
                {
                    Writer.WriteLine($"{Name2}|{cmbIssuTybe}|{Description}|{CustomerNum}");
                }
            }
            public static void LoadInfoSupport(DataGridView dgvSupport)
            {
                if (File.Exists("Support.Txt"))
                {
                    string[] Rows = File.ReadAllLines("Support.Txt");

                    foreach(string s in Rows)
                    {

                        string[] Data2= s.Split('|');
                        dgvSupport.Rows.Add(Data2);

                    }

                }





            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvSupport.Rows.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dgvSupport.Rows.Clear();
        }
    }
    
  }  







        



    
