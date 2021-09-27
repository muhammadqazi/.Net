using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=coffee_db.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            security rg = new security();
            rg.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginEmail.Text = "";
            loginPassword.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM users_tbl WHERE password= '" + loginPassword.Text + "' and email= '" + loginEmail.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read() == true)
            {
                new Form1().Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid email or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginEmail.Text = "";
                loginPassword.Text = "";
                con.Close();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ordert or = new ordert();
            or.Show();
            
        }
    }
 }

