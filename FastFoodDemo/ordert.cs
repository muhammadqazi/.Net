using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FastFoodDemo
{
    public partial class ordert : Form
    {

        Class1 c = new Class1();
        string query;
        public ordert()
        {
            InitializeComponent();
        }

        private void orderCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string catagory = orderCat.Text;
            query = "select ProductName from item_tbl where catagory = '" + catagory + "'";
            showItemList(query);
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void orderSearchBox_TextChanged(object sender, EventArgs e)
        {
            string catagory = orderCat.Text;
            query = "select ProductName from item_tbl where catagory = '" + catagory + "' and ProductName like '"+orderSearchBox.Text+"%'";
            showItemList(query);
        }
        private void showItemList(string query)
        {
            DataSet ds = c.getData(query);

            orderSearchList.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                orderSearchList.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void orderSearchList_SelectedIndexChanged(object sender, EventArgs e)
        {
            oderUpDown.ResetText();
            orderTotal.Clear();

            string text = orderSearchList.GetItemText(orderSearchList.SelectedItem);
            orderName.Text = text;
            query = "select UnitPrice from item_tbl where ProductName = '"+text+"' ";

            DataSet ds = c.getData(query);
            try
            {
                orderPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
               
            }
        }

        private void oderUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Int64 quan = Int64.Parse(oderUpDown.Value.ToString());
                Int64 price = Int64.Parse(orderPrice.Text);

                orderTotal.Text = (quan * price).ToString();
            }
            catch { }
        }

        private void orderClearBtn_Click(object sender, EventArgs e)
        {
            orderName.Text = "";
            oderUpDown.Value = 0;
            orderTotal.Text = "";
            orderPrice.Text = "";
            orderSearchBox.Text = "";
            orderSearchList.Items.Clear();
            orderCat.Text = "";
        }

        protected int n, total = 0;
        int amount;
        private void orderGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(orderGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
                
            }
            catch
            {

            }
        }

        private void orderRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                orderGrid.Rows.RemoveAt(this.orderGrid.SelectedRows[0].Index);
            }
            catch
            {

            }
            total -= amount;
            TotalPriceOrder.Text = total + "TL";
        }

        private void orderPrintBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sucessfully order placed you wana print?", "Sucess", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
          

                DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
                printer.Title = "Customer Bill";
                printer.SubTitle = string.Format("Date : {0} ", DateTime.Now.Date);
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Total Payable amount is " + TotalPriceOrder.Text;
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(orderGrid);

               

               
            }
            else
            {

                total = 0;
                orderGrid.Rows.Clear();
                TotalPriceOrder.Text = total + "TL";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 it = new Form1();
            it.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void orderAddCartBtn_Click(object sender, EventArgs e)
        {
            if (orderTotal.Text != "0" && orderTotal.Text != "")
            {
                n = orderGrid.Rows.Add();
                orderGrid.Rows[n].Cells[0].Value = orderName.Text;
                orderGrid.Rows[n].Cells[1].Value = orderPrice.Text;
                orderGrid.Rows[n].Cells[2].Value = oderUpDown.Value;
                orderGrid.Rows[n].Cells[3].Value = orderTotal.Text;

                total = total + int.Parse(orderTotal.Text);
                TotalPriceOrder.Text = total + "TL";
            }
            else
            {
                MessageBox.Show("Minimun quantity needs to be one ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
