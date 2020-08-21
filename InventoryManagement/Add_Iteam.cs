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
    public partial class Add_Iteam : Form
    {
        string s_n = "";
        string m = "";
        public Add_Iteam()
        {
            InitializeComponent();
            string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = con_str;
            con.Open();
            OracleCommand com = new OracleCommand();
            com.CommandText = "select name from supplier order by name ASC";
            com.Connection = con;
            com.CommandType = CommandType.Text;
            OracleDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                s_combobox.Items.Add(dr.GetString(0));
            }
            s_combobox.SelectedIndex = 0;
            s_n = s_combobox.Text;
            string[] list = { "kg", "pics", "litre", "mitre" };
            foreach (string l in list) {
                m_combobox.Items.Add(l);
            }
            m_combobox.SelectedIndex = 0;
            m = m_combobox.Text;
        }

        ErrorProvider errorProvider = new ErrorProvider();
        private void id_box_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(id_box.Text))
            {
                e.Cancel = true;
                id_box.Focus();
                errorProvider.SetError(id_box, "Please fill the form");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(id_box, "");
            }
        }

        private void name_box_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(name_box.Text))
            {
                e.Cancel = true;
                name_box.Focus();
                errorProvider.SetError(name_box, "Please fill the form");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(name_box, "");
            }
        }

        private void qty_box_Validating(object sender, CancelEventArgs e)
        {
            int x = 0;
            float y = 0;
            if (Int32.TryParse(qty_box.Text, out x)||float.TryParse(qty_box.Text,out y))
            {
                e.Cancel = false;
                errorProvider.SetError(qty_box, "");
            }
            else
            {
                e.Cancel = true;
                qty_box.Focus();
                errorProvider.SetError(qty_box, "Please Enter a number!");
                
            }
        }

        private void op_box_Validating(object sender, CancelEventArgs e)
        {
            int x = 0;
            float y = 0;
            if (Int32.TryParse(op_box.Text, out x) || float.TryParse(op_box.Text, out y))
            {
                e.Cancel = false;
                errorProvider.SetError(op_box, "");
            }
            else
            {
                e.Cancel = true;
                op_box.Focus();
                errorProvider.SetError(op_box, "Please Enter a number!");

            }
        }

        private void in_box_Validating(object sender, CancelEventArgs e)
        {
            int x = 0;
            float y = 0;
            if (Int32.TryParse(in_box.Text, out x) || float.TryParse(in_box.Text, out y))
            {
                e.Cancel = false;
                errorProvider.SetError(in_box, "");
            }
            else
            {
                e.Cancel = true;
                in_box.Focus();
                errorProvider.SetError(in_box, "Please Enter a number!");

            }
        }


        private void button_add_Click(object sender, EventArgs e)
        {
            string inv_id = id_box.Text;
            string name = name_box.Text;
            string qty = qty_box.Text;
            string op = op_box.Text;
            string ip = in_box.Text;

            string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = con_str;
            con.Open();
            OracleCommand com = new OracleCommand();
            com.CommandText = "select inv_id from inventory where inv_id='" + inv_id + "'";
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
                MessageBox.Show("Item Id already exist! Please select a unique Id.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                //textBox2.Focus();
                id_box.Text = "";
            }
            else if (count == 0)
            {
                try
                {
                    //OracleCommand com = new OracleCommand();
                    com.CommandText = "INSERT INTO inventory VALUES (:p_id,:name,:qty, :meas,:op,:inp,:sn)";
                    com.Parameters.Add("p_id", inv_id);
                    com.Parameters.Add("name", name);
                    com.Parameters.Add("qty", qty);
                    com.Parameters.Add("meas", m);
                    com.Parameters.Add("op", op);
                    com.Parameters.Add("inp",ip );
                    com.Parameters.Add("sn", s_n);
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
            con.Close();
        }
    }
}
