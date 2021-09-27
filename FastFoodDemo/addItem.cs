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
    public partial class addItem : Form
    {
        public addItem()
        {
            InitializeComponent();
        }
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=coffee_db.mdb");
        OleDbCommand command = new OleDbCommand();

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itemAddBtn_Click(object sender, EventArgs e)
        {
            if ( itemCatAdd.Text=="" && itemNameAdd.Text == "" && itemQuantityAdd.Text == "" && itemAddPrice.Text == "")
            {
                MessageBox.Show("Please add catagory , name , quantity and product", "Adding Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else if (itemCustomAdd.Text == "")
            {
                MessageBox.Show("Please add NO if there are no custom requrements ", "Adding Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                string add = "insert into item_tbl (catagory , ProductName , Quantity , Custom , UnitPrice ) values ('" + itemCatAdd.Text+"','" + itemNameAdd.Text + "','" + itemQuantityAdd.Text + "' , '"+itemCustomAdd.Text+"' , '"+ itemAddPrice.Text + "')";
                command = new OleDbCommand(add, connection);
                command.ExecuteNonQuery();
                connection.Close();

                itemCatAdd.Text = "";
                itemNameAdd.Text = "";
                itemQuantityAdd.Text = "";
                itemCustomAdd.Text = "";
                itemAddPrice.Text = "";

                MessageBox.Show("Sucessfully added", "Sucess ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void itemClearBtn_Click(object sender, EventArgs e)
        {

            itemCatAdd.Text = "";
            itemNameAdd.Text = "";
            itemQuantityAdd.Text = "";
            itemCustomAdd.Text = "";
            itemAddPrice.Text = "";
        }

        private void addItem_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            items it = new items();
            it.Show();
        }
    }
}
