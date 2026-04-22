using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                cmbIssueType.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtCustomerNum.Text))
            {
                MessageBox.Show("Please fill in ALL fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dataGridView1.Rows.Add(txtName.Text, cmbIssueType.Text, txtDescription.Text, txtCustomerNum.Text);

            MessageBox.Show("Support request sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtName.Clear();
            cmbIssueType.SelectedIndex = -1;
            txtDescription.Clear();
            txtCustomerNum.Clear();
            txtName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
    }
