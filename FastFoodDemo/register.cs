using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class register : Form
    {
        Class1 cl = new Class1();
        string query;

        public register()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login sc = new login();
            sc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            regUserBox.Text = "";
            regUserPasswordBox.Text = "";
            regEmailBox.Text = "";
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            if (regUserBox.Text == "")
            {
                MessageBox.Show("Please fill the name field" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else if (regEmailBox.Text == "")
            {
                MessageBox.Show("Please fill the email field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (regUserPasswordBox.Text == "")
            {
                MessageBox.Show("Please fill the password field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                query = "insert into users_tbl values  ('" + regUserBox.Text + "' , '" + regUserPasswordBox.Text + "' , '" + regEmailBox.Text + "')";
                cl.setData(query);

                regUserBox.Text = "";
                regUserPasswordBox.Text = "";
                regEmailBox.Text = "";
            }
        }

        private void regUserPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
