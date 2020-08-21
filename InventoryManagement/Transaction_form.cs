using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Transaction_form : Form
    {
        string cart_id = "";
        string item = "";
        public Transaction_form()
        {
            InitializeComponent();
            string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = con_str;
            con.Open();
            OracleCommand com = new OracleCommand();
            com.CommandText = "select * from transaction";
            com.Connection = con;
            com.CommandType = CommandType.Text;
            OracleDataReader dr = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dataGridView1.DataSource = table;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete all records?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = con_str;
                con.Open();
                OracleCommand com = new OracleCommand();
                com.CommandText = "delete from transaction";
                com.Connection = con;
                com.CommandType = CommandType.Text;
                dataGridView1.Rows.Clear();
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cart_id))
            {
                MessageBox.Show("Please select a record from the list!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
                    OracleConnection con = new OracleConnection();
                    con.ConnectionString = con_str;
                    con.Open();
                    OracleCommand com = new OracleCommand();
                    com.CommandText = "delete from transaction where cart_id=:c_id and ITEM_ID=:it_id";
                    com.Parameters.Add("c_id", cart_id);
                    com.Parameters.Add("it_id", item);
                    com.Connection = con;
                    com.CommandType = CommandType.Text;
                    int success = com.ExecuteNonQuery();
                    if (success>0)
                    {
                        OracleCommand com2 = new OracleCommand();
                        com2.CommandText = "select * from transaction";
                        com2.Connection = con;
                        com2.CommandType = CommandType.Text;
                        OracleDataReader dr = com2.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(dr);
                        dataGridView1.DataSource = table;
                    }
                }
            }
        }

        private void cart_b_TextChanged(object sender, EventArgs e)
        {
            string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = con_str;
            con.Open();
            OracleCommand com = new OracleCommand();
            com.CommandText = "select * from transaction where cart_id like '" + cart_b.Text + "%'"
                + "or CUSTOMER_NAME like '" + cart_b.Text + "%'" + "or ITEM_ID like '" + cart_b.Text + "%'"
                + "or ITEM_NAME like '" + cart_b.Text + "%'" + "or SUPPLIER_NAME like '" + cart_b.Text + "%'"
                + "or PURCHASE_DATE like '" + cart_b.Text + "%'" + "or CONTACT like '" + cart_b.Text + "%'";
            com.Connection = con;
            com.CommandType = CommandType.Text;
            OracleDataReader dr = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                cart_id = row.Cells[0].Value.ToString();
                item = row.Cells[2].Value.ToString();
            }
        }
    }
}
