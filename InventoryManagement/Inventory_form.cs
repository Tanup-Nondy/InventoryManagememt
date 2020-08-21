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
    public partial class Inventory_form : Form
    {
        string selected_inv_id = "";
        string s_n = "";
        string m = "";
        public Inventory_form()
        {
            InitializeComponent();
            string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = con_str;
            con.Open();
            OracleCommand com = new OracleCommand();
            com.CommandText = "select * from inventory";
            com.Connection = con;
            com.CommandType = CommandType.Text;
            OracleDataReader dr = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dataGridView1.DataSource = table;
            
            com.CommandText = "select name from supplier order by name ASC";
            com.Connection = con;
            com.CommandType = CommandType.Text;
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr.GetString(0));
            }
            comboBox2.SelectedIndex = 0;
            s_n = comboBox2.Text;
            string[] list = { "kg", "pics", "litre", "mitre" };
            foreach (string l in list)
            {
                comboBox1.Items.Add(l);
            }
            comboBox1.SelectedIndex = 0;
            m = comboBox1.Text;
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = con_str;
            con.Open();
            OracleCommand com = new OracleCommand();
            com.CommandText = "select * from inventory where inv_id like '" + textBox1.Text + "%'"
                + "or name like '" + textBox1.Text + "%'"+ "or supplier_name like '" + textBox1.Text + "%'";
            com.Connection = con;
            com.CommandType = CommandType.Text;
            OracleDataReader dr = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dataGridView1.DataSource = table;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Add_Iteam form_it = new Add_Iteam();
             if (form_it.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Item data added", "Success!", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                //supplier_listBox.Items.Clear();
                string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = con_str;
                con.Open();
                OracleCommand com = new OracleCommand();
                com.CommandText = "select * from inventory";
                com.Connection = con;
                com.CommandType = CommandType.Text;
                OracleDataReader dr = com.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(dr);
                dataGridView1.DataSource = table;
                con.Close();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                selected_inv_id = row.Cells[0].Value.ToString();
                //MessageBox.Show(inv_id);
            }
            try
            {
                //MessageBox.Show(selected_inv_id);
                string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = con_str;
                con.Open();
                OracleCommand com = new OracleCommand();
                com.CommandText = "select * from inventory where inv_id = '" + selected_inv_id + "'";
                com.Connection = con;
                com.CommandType = CommandType.Text;
                OracleDataReader dr = com.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    id_box.Text = dr.GetString(0);
                    textBox2.Text = dr.GetString(1);
                    textBox3.Text = dr.GetFloat(2).ToString();
                    p_lb.Text = dr.GetFloat(4).ToString();
                    textBox4.Text = dr.GetFloat(4).ToString();
                    textBox5.Text = dr.GetFloat(5).ToString();
                    comboBox1.Text = dr.GetString(3);
                    comboBox2.Text = dr.GetString(6);
                }
            }
            catch
            {
                throw;
            }
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                selected_inv_id = row.Cells[0].Value.ToString();
                try
                {
                    //MessageBox.Show(selected_inv_id);
                     string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
                     OracleConnection con = new OracleConnection();
                     con.ConnectionString = con_str;
                     con.Open();
                     OracleCommand com = new OracleCommand();
                     com.CommandText = "select * from inventory where inv_id='" + selected_inv_id + "'";
                     //com.CommandText = "select * from inventory";
                     com.Connection = con;
                     com.CommandType = CommandType.Text;
                     OracleDataReader dr = com.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        id_box.Text = dr.GetString(0);
                        textBox2.Text = dr.GetString(1);
                        textBox3.Text = dr.GetFloat(2).ToString();
                        p_lb.Text = dr.GetFloat(4).ToString();
                        textBox4.Text = dr.GetFloat(4).ToString();
                        textBox5.Text = dr.GetFloat(5).ToString();
                        comboBox1.Text = dr.GetString(3);
                        comboBox2.Text = dr.GetString(6);
                       
                    }
                    con.Close();
                }
                catch
                {
                    throw;
                }
                
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string iteam = textBox2.Text;
            string id = id_box.Text;
            float qty =float.Parse(textBox3.Text);
            float cp =float.Parse( textBox4.Text);
            float inc =float.Parse(textBox5.Text);
            string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = con_str;
            con.Open();
            OracleCommand com = new OracleCommand();
            if (id != selected_inv_id) { 
                com.CommandText = "select inv_id from inventory where inv_id='" + id + "'";
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
                    MessageBox.Show("Item Id already exist! Please select a unique Id."+selected_inv_id, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                    //textBox2.Focus();
                    id_box.Text = "";
                }
                else if (count == 0)
                {
                    try
                    {
                        
                        com.CommandText = "update inventory set inv_id =:id ,name=:n ,quantity =:q ,measurement =:m ,original_price=:o ,increased_price =:i ,supplier_name =:s WHERE inv_id =:cid ";
       
                        com.Parameters.Add("id", id);
                        com.Parameters.Add("n", iteam);
                        com.Parameters.Add("q", qty);
                        com.Parameters.Add("m", m);
                        com.Parameters.Add("o", cp);
                        com.Parameters.Add("i", inc);
                        com.Parameters.Add("s", s_n);
                        com.Parameters.Add("cid", selected_inv_id);
                        com.Connection = con;
                        com.CommandType = CommandType.Text;
                        int success = com.ExecuteNonQuery();
                        if (success > 0)
                        {
                            MessageBox.Show("Item data updated", "Success!", MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                            com.CommandText = "select * from inventory";
                            com.Connection = con;
                            com.CommandType = CommandType.Text;
                            dr = com.ExecuteReader();
                            DataTable table = new DataTable();
                            table.Load(dr);
                            dataGridView1.DataSource = table;
                            id_box.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            p_lb.Text = "";
                            textBox4.Text = "";
                            textBox5.Text = "";
                            comboBox1.Text = "";
                            comboBox2.Text = "";
                        }
                    }
                    catch 
                    {
                        throw;
                    }
                }
            }
            else
            {
                try
                {
                    com.CommandText = "update inventory set inv_id =:id ,name=:n ,quantity =:q ,measurement =:m ,original_price=:o ,increased_price =:i ,supplier_name =:s WHERE inv_id =:cid ";
                    
                    com.Parameters.Add("id", id);
                    com.Parameters.Add("n", iteam);
                    com.Parameters.Add("q", qty);
                    com.Parameters.Add("m", m);
                    com.Parameters.Add("o", cp);
                    com.Parameters.Add("i", inc);
                    com.Parameters.Add("s", s_n);
                    com.Parameters.Add("cid", selected_inv_id);
                    com.Connection = con;
                    com.CommandType = CommandType.Text;
                    int success = com.ExecuteNonQuery();
                    if (success > 0)
                    {
                        MessageBox.Show("Item data updated", "Success!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                        com.CommandText = "select * from inventory";
                        com.Connection = con;
                        com.CommandType = CommandType.Text;
                        OracleDataReader dr = com.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(dr);
                        dataGridView1.DataSource = table;
                        id_box.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        p_lb.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        comboBox1.Text = "";
                        comboBox2.Text = "";
                    }
                }
                catch
                {
                    throw;
                }
            }
            con.Close();
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
            int x = 0;
            float y = 0;
            if (Int32.TryParse(textBox3.Text, out x) || float.TryParse(textBox3.Text, out y))
            {
                e.Cancel = false;
                errorProvider.SetError(textBox3, "");
            }
            else
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider.SetError(textBox3, "Please Enter a number!");

            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            int x = 0;
            float y = 0;
            if (Int32.TryParse(textBox4.Text, out x) || float.TryParse(textBox4.Text, out y))
            {
                e.Cancel = false;
                errorProvider.SetError(textBox4, "");
            }
            else
            {
                e.Cancel = true;
                textBox4.Focus();
                errorProvider.SetError(textBox4, "Please Enter a number!");

            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            int x = 0;
            float y = 0;
            if (Int32.TryParse(textBox5.Text, out x) || float.TryParse(textBox5.Text, out y))
            {
                e.Cancel = false;
                errorProvider.SetError(textBox5, "");
            }
            else
            {
                e.Cancel = true;
                textBox5.Focus();
                errorProvider.SetError(textBox5, "Please Enter a number!");

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(selected_inv_id))
                {
                    MessageBox.Show("Please select an item from list!", "Success!", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                }
                else { 
                    string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
                    OracleConnection con = new OracleConnection();
                    con.ConnectionString = con_str;
                    con.Open();
                    OracleCommand com = new OracleCommand();
                    com.CommandText = "delete from inventory where inv_id='" + selected_inv_id + "'";
                    com.Connection = con;
                    com.CommandType = CommandType.Text;
                    int row_update = com.ExecuteNonQuery();
                    if (row_update > 0)
                    {
                        MessageBox.Show("User data deleted", "Success!", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                        com.CommandText = "select * from inventory";
                        com.Connection = con;
                        com.CommandType = CommandType.Text;
                        OracleDataReader dr = com.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(dr);
                        dataGridView1.DataSource = table;
                        id_box.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        p_lb.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        comboBox1.Text = "";
                        comboBox2.Text = "";
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select an item from list!", "Success!", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }
    }
}
