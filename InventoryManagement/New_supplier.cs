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
    public partial class New_supplier : Form
    {
        public New_supplier()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string sup_id = textBox2.Text;
            string name = textBox1.Text;
            string contact = textBox3.Text;
            string address = textBox4.Text;
             
            string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = con_str;
            con.Open();
            OracleCommand com = new OracleCommand();
            com.CommandText = "select sup_id from supplier where sup_id='" + sup_id + "'";
            com.Connection = con;
            com.CommandType = CommandType.Text;
            OracleDataReader dr = com.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count++;
            }
            if (count > 0)
            {
                MessageBox.Show("Supplier Id already exist! Please select a unique Id.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                //textBox2.Focus();
                textBox2.Text = "";
            }
            else if (count == 0)
            {
                try
                {
                    //OracleCommand com = new OracleCommand();
                    com.CommandText = "INSERT INTO supplier VALUES (:s_id,:username,:conn, :address)";
                    com.Parameters.Add("s_id", sup_id);
                    com.Parameters.Add("username", name);
                    com.Parameters.Add("address", address);
                    com.Parameters.Add("conn", contact);
                    com.Connection = con;
                    com.CommandType = CommandType.Text;
                    int success = com.ExecuteNonQuery();
                    if (success > 0)
                    {
                        this.Hide();
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
            
        ErrorProvider errorProvider = new ErrorProvider();
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider.SetError(textBox1, "Please fill the form");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox1, "");
            }
        }
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider.SetError(textBox2, "Please fill the form");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox2, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider.SetError(textBox3, "Please fill the form");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox3, "");
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                e.Cancel = true;
                textBox4.Focus();
                errorProvider.SetError(textBox4, "Please fill the form");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox4, "");
            }
        }

        
    }
}
