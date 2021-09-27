using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace FastFoodDemo
{
    class Class1
    {
        protected OleDbConnection getConnection()
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=coffee_db.mdb");
            OleDbCommand command = new OleDbCommand();
            OleDbDataAdapter dataa = new OleDbDataAdapter();
            return connection;
        }
        public DataSet getData(string query)
        {
            OleDbConnection connection = getConnection();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = query;
            OleDbDataAdapter dataa = new OleDbDataAdapter(command);
            DataSet dset = new DataSet();
            dataa.Fill(dset);
            return dset;
        }
        public void setData(string query)
        {
            OleDbConnection connection = getConnection();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Data Processed sucessfully", " Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
