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
    public partial class security : Form
    {
        public security()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void secureBTn_Click(object sender, EventArgs e)
        {
            if(secureBox.Text=="admin")
            {
                this.Hide();
                register rg = new register();
                rg.Show();
            }
            else
            {
                if(MessageBox.Show("Acess Denied" , "Wrong Credentials" , MessageBoxButtons.RetryCancel , MessageBoxIcon.Warning) == DialogResult.Retry)
                {
                    this.Hide();
                    security sc = new security();
                    sc.Show();
                }
                else
                {
                    MessageBox.Show("Application exit");
                    Application.Exit();
                }
            }
        }
    }
}
