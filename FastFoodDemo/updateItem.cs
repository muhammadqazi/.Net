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
    public partial class updateItem : Form
    {
        Class1 cl = new Class1();
        string query;
        public updateItem()
        {
            InitializeComponent();
        }
       
        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = "update item_tbl set ProductName='"+itemNameUpdate.Text+ "', catagory='" + itemCatUpdate.Text + "' , UnitPrice= '"+itemPriceUpdate.Text+"' where id="+id+"";
            cl.setData(query);
            loadData();

            itemCatUpdate.Text = "";
            itemNameUpdate.Text = "";
            itemPriceUpdate.Text = "";
            itemCustomUpdate.Text = "";

        }

        private void UpdateBtnclear_Click(object sender, EventArgs e)
        {
            itemCatUpdate.Text = "";
            itemNameUpdate.Text = "";
            itemPriceUpdate.Text = "";
            itemCustomUpdate.Text = "";
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void itemCustomUpdate_TextChanged(object sender, EventArgs e)
        {
            query = "select * from item_tbl where ProductName like '"+itemCustomUpdate.Text+"%'";
            DataSet ds = cl.getData(query);
            dataGridUpdate.DataSource = ds.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void itemQuantityUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void itemNameUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void itemCatUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateItem_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            query = "select * from item_tbl";
            DataSet ds = cl.getData(query);
            dataGridUpdate.DataSource = ds.Tables[0];
        }
        int id;
        private void dataGridUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridUpdate.Rows[e.RowIndex].Cells[0].Value.ToString());
            string catagory = dataGridUpdate.Rows[e.RowIndex].Cells[1].Value.ToString();
            string name = dataGridUpdate.Rows[e.RowIndex].Cells[2].Value.ToString();
            int price = int.Parse(dataGridUpdate.Rows[e.RowIndex].Cells[5].Value.ToString());

            itemCatUpdate.Text = catagory;
            itemNameUpdate.Text = name;
            itemPriceUpdate.Text = price.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            items it = new items();
            it.Show();
        }
    }
}
