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
    public partial class removeitem : Form
    {
        Class1 cl = new Class1();
        string query;
        public removeitem()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void removeitem_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            query = "select * from item_tbl";
            DataSet ds =  cl.getData(query);
            delDataGrid.DataSource = ds.Tables[0];

        }

        private void delSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from item_tbl where ProductName like '"+delSearch.Text+"%'";
            DataSet ds = cl.getData(query);
            delDataGrid.DataSource = ds.Tables[0];
        }

        private void delDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete item?" , "Important " , MessageBoxButtons.OKCancel , MessageBoxIcon.Warning)==DialogResult.OK)
            {
                int id =int.Parse(delDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString()) ;

                query = "delete from item_tbl where id="+id+"";
                cl.setData(query);
                loadData();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            items it = new items();
            it.Show();
        }
    }
}
