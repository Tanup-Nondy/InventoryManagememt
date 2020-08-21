using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace InventoryManagement
{
    public partial class Admin_form : Form
    {
        public static string un = "";

        public Admin_form()
        {
            InitializeComponent();
        }

        private void Admin_form_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text.ToString();
            string pass = textBox2.Text.ToString();
            
            if (uname.Equals("") || pass.Equals(""))
            {
                MessageBox.Show("Please fill the Username/Password", "Null data", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {
                string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = con_str;
                con.Open();
                OracleCommand com = new OracleCommand();
                com.CommandText = "select username,password from admin "+ "WHERE username = '" + uname + "' AND password = '" + pass + "'";
                com.Connection = con;
                com.CommandType = CommandType.Text;
                OracleDataReader dr = com.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count++;
                }
                if (count == 0)
                {
                    MessageBox.Show("Invalid UserID/Password", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else if(count==1)
                {
                    MessageBox.Show("Admin Login successfull !", "Success!", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                   
                    this.Hide();
                    
                    //Add_user f = new Add_user();
                    //f.Show();
                    this.DialogResult = DialogResult.OK;
                }
               
                //con.Close();
            }
        }
    }
}
