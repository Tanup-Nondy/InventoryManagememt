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
    public partial class Add_user : Form
    {
        //Admin_form f = new Admin_form();
        string cur_iteam = "";
        //int deleted = 0;
        //int inserted = 0;
        //int updated = 0;
        public Add_user()
        {
            InitializeComponent();
            //if (f.ShowDialog() == DialogResult.OK)
            //{
                string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = con_str;
                con.Open();
                OracleCommand com = new OracleCommand();
                com.CommandText = "select username from login";
                com.Connection = con;
                com.CommandType = CommandType.Text;
                OracleDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    user_listBox.Items.Add(dr.GetString(0));
                }
                con.Close();
           // }
        }

        private void user_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cur_iteam = user_listBox.SelectedItem.ToString();
            string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = con_str;
            con.Open();
            OracleCommand com = new OracleCommand();
            com.CommandText = "select * from login " + "WHERE username = '" + cur_iteam +"'";
            com.Connection = con;
            com.CommandType = CommandType.Text;
            OracleDataReader dr = com.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                uname_textBox.Text = dr.GetString(1);
                name_textBox.Text = dr.GetString(3);
                address_textBox.Text = dr.GetString(4);
                con_textBox.Text = dr.GetString(5);
            }
            con.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string uname = uname_textBox.Text;
            string name = name_textBox.Text;
            string address = address_textBox.Text;
            string contact = con_textBox.Text;
            try
            {
                cur_iteam = user_listBox.SelectedItem.ToString();
                if (uname != cur_iteam)
                {
                    string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
                    OracleConnection con = new OracleConnection();
                    con.ConnectionString = con_str;
                    con.Open();
                    OracleCommand com = new OracleCommand();
                    com.CommandText = "select username from login where username='" + uname + "'";
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
                        MessageBox.Show("User name already exist! Please select a unique username.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
                        //textBox2.Focus();
                        uname_textBox.Text = "";
                    }
                    else if (count == 0)
                    {
                        try
                        {
                            /*string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
                            OracleConnection con = new OracleConnection();
                            con.ConnectionString = con_str;
                            con.Open();
                            OracleCommand com = new OracleCommand();*/
                            com.CommandText = "update login set username = '" + uname + "',name= '" + name + "',address = '" + address + "',contact = '" + contact + "'" + "WHERE username = '" + cur_iteam + "'";
                            com.Connection = con;
                            com.CommandType = CommandType.Text;
                            int row_update = com.ExecuteNonQuery();
                            if (row_update > 0)
                            {
                                MessageBox.Show("User data updated", "Success!", MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                                user_listBox.Items.Clear();
                                com.CommandText = "select username from login";
                                com.Connection = con;
                                com.CommandType = CommandType.Text;
                                OracleDataReader dr2 = com.ExecuteReader();
                                while (dr2.Read())
                                {
                                    user_listBox.Items.Add(dr2.GetString(0));
                                }
                            }

                            con.Close();
                        }

                        catch (Exception ex)
                        {
                            throw;
                        }
                    }
                }
                else
                {
                    string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
                    OracleConnection con = new OracleConnection();
                    con.ConnectionString = con_str;
                    con.Open();
                    OracleCommand com = new OracleCommand();
                    com.CommandText = "update login set username = '" + uname + "',name= '" + name + "',address = '" + address + "',contact = '" + contact + "'" + "WHERE username = '" + cur_iteam + "'";
                    com.Connection = con;
                    com.CommandType = CommandType.Text;
                    int row_update = com.ExecuteNonQuery();
                    if (row_update > 0)
                    {
                        MessageBox.Show("User data updated", "Success!", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                        user_listBox.Items.Clear();
                        com.CommandText = "select username from login";
                        com.Connection = con;
                        com.CommandType = CommandType.Text;
                        OracleDataReader dr2 = com.ExecuteReader();
                        while (dr2.Read())
                        {
                            user_listBox.Items.Add(dr2.GetString(0));
                        }
                    }

                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("Please select a user from list!", "Success!", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            
            try
            {
                cur_iteam = user_listBox.SelectedItem.ToString();
                string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = con_str;
                con.Open();
                OracleCommand com = new OracleCommand();
                com.CommandText = "delete from login where username='"+cur_iteam+"'";
                com.Connection = con;
                com.CommandType = CommandType.Text;
                int row_update = com.ExecuteNonQuery();
                if (row_update > 0)
                {
                    MessageBox.Show("User data deleted", "Success!", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    user_listBox.Items.Clear();
                    uname_textBox.Text = "";
                    name_textBox.Text = "";
                    address_textBox.Text = "";
                    con_textBox.Text = "";
                    cur_iteam = "";
                    com.CommandText = "select username from login";
                    com.Connection = con;
                    com.CommandType = CommandType.Text;
                    OracleDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        user_listBox.Items.Add(dr.GetString(0));
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a user from list!", "Success!", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            New_user form_n = new New_user();
            if (form_n.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("User data added", "Success!", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                user_listBox.Items.Clear();
                string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = con_str;
                con.Open();
                OracleCommand com = new OracleCommand();
                com.CommandText = "select username from login";
                com.Connection = con;
                com.CommandType = CommandType.Text;
                OracleDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    user_listBox.Items.Add(dr.GetString(0));
                }
                con.Close();
            }
        }
        ErrorProvider errorProvider = new ErrorProvider();
        private void uname_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(uname_textBox.Text))
            {
                e.Cancel = true;
                uname_textBox.Focus();
                errorProvider.SetError(uname_textBox, "Please fill the form");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(uname_textBox, "");
            }
        }

        private void name_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(name_textBox.Text))
            {
                e.Cancel = true;
                name_textBox.Focus();
                errorProvider.SetError(name_textBox, "Please fill the form");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(name_textBox, "");
            }
        }

        private void con_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(con_textBox.Text))
            {
                e.Cancel = true;
                con_textBox.Focus();
                errorProvider.SetError(con_textBox, "Please fill the form");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(con_textBox, "");
            }
        }

        private void address_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(address_textBox.Text))
            {
                e.Cancel = true;
                address_textBox.Focus();
                errorProvider.SetError(address_textBox, "Please fill the form");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(address_textBox, "");
            }
        }
    }
}
