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
    public partial class New_user : Form
    {
        public New_user()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string uname = textBox2.Text;
            string contact = textBox3.Text;
            string add = textBox4.Text;
            string pass = textBox5.Text;
            string cpass = textBox6.Text;
            if(String.IsNullOrEmpty(name)|| String.IsNullOrEmpty(uname) || String.IsNullOrEmpty(contact) || String.IsNullOrEmpty(add) || String.IsNullOrEmpty(pass) || String.IsNullOrEmpty(cpass))
            {

            }
            else 
            {
                if (pass.Length < 6 || cpass.Length < 6)
                {

                }
                else if ((cpass != pass))
                {
                    textBox6.Focus();
                    MessageBox.Show("Password doesn not match!", "Error!", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                }
                else
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
                        textBox2.Text = "";
                    }
                    else if (count == 0)
                    {
                        //insert into login VALUES(user_id.nextval,'abcdef','avcd','dfjhg','dhaka',0195765567);
                        //com.CommandText = "insert into login values (user_id.nextval,'" + uname + "','"+pass+"','"+name+"','"+add+"','"+contact+"')'";
                        try
                        {
                            com.CommandText = "INSERT INTO login VALUES (user_id.nextval,:username,:pass, :name, :address, :conn)";
                            com.Parameters.Add("username", uname);
                            com.Parameters.Add("pass", pass);
                            com.Parameters.Add("name", name);
                            com.Parameters.Add("address", add);
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
            }
            
        }
        ErrorProvider errorProvider = new ErrorProvider();
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                //textBox1.Focus();
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

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox5.Text))
            {
                e.Cancel = true;
                textBox5.Focus();
                errorProvider.SetError(textBox5, "Please fill the form");
            }
            else if (textBox5.Text.Length < 6)
            {
                e.Cancel = true;
                textBox5.Focus();
                errorProvider.SetError(textBox5, "Provide at least 6 characters");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox5, "");
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox6.Text))
            {
                e.Cancel = true;
                textBox6.Focus();
                errorProvider.SetError(textBox6, "Please fill the form");
            }
            else if (textBox6.Text.Length < 6)
            {
                e.Cancel = true;
                textBox6.Focus();
                errorProvider.SetError(textBox6, "Provide at least 6 characters");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox6, "");
            }
        }
    }
}
