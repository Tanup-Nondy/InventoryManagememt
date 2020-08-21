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
    public partial class Checkout_form : Form
    {
        string cur_iteam = "";
        string item = "";
        string del_item = "";
        float unit_price = 0;
        float order_price=0;
        float available = 0;
        float remain = 0;
        float total_sale = 0;
        float tendered = 0;
        float cash_back = 0;
        float ten, c = 0;
        Dictionary<string,float> avail_array = new Dictionary<string, float>();
        Dictionary<string, float> bought_array = new Dictionary<string, float>();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        public Checkout_form()
        {
            InitializeComponent();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt2.Columns.Add("Id");
            dt2.Columns.Add("Name");
            dt2.Columns.Add("Measurement");
            dt2.Columns.Add("Unit Price");
            dt2.Columns.Add("Quantity");
            dt2.Columns.Add("Total Price");
            dt2.Columns.Add("Supplier");
            string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = con_str;
            con.Open();
            OracleCommand com = new OracleCommand();
            try
            {
                com.CommandText = "select * from inventory";
                com.Connection = con;
                com.CommandType = CommandType.Text;
                OracleDataReader dr = com.ExecuteReader();
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    DataRow drow = dt.NewRow();
                    
                    drow[0] = dr.GetString(0).ToString();
                    drow[1] = dr.GetString(1).ToString();
                    dt.Rows.Add(drow);
                    avail_array[dr.GetString(0)] = dr.GetFloat(2);
                    //MessageBox.Show(dr.GetString(0));
                }
            }
            catch
            {
                throw;
            }
            con.Close();
            dataGridView2.DataSource = dt;
            dataGridView1.DataSource = dt2;
            
        }
        
        private void tendered_lb_Click(object sender, EventArgs e)
        {

        }

        private void qr_b_TextChanged(object sender, EventArgs e)
        {
            int x = 0;
            float y = 0;
            if (String.IsNullOrEmpty(qr_b.Text))
            {
                total_b.Text = "";
            }
            else if (Int32.TryParse(qr_b.Text, out x) || float.TryParse(qr_b.Text, out y))
            {
                float orders = float.Parse(qr_b.Text);
                float qa = float.Parse(qa_b.Text);
                if (orders > qa || orders <= 0)
                {
                    MessageBox.Show("Not enough product or invalid required number!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                }
                else
                {
                    remain = available - orders;
                    order_price = unit_price * orders;
                    total_b.Text = order_price.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number number!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);

            }
            
        }
        ErrorProvider errorProvider = new ErrorProvider();

        private void qr_b_Validating(object sender, CancelEventArgs e)
        {
            int x = 0;
            float y = 0;
            if (String.IsNullOrEmpty(qr_b.Text))
            {
                e.Cancel = true;
                qr_b.Focus();
                errorProvider.SetError(qr_b, "Cant't be empty!");
            }
            else if (Int32.TryParse(qr_b.Text, out x) || float.TryParse(qr_b.Text, out y))
            {
                e.Cancel = false;
                errorProvider.SetError(qr_b, "");
            }
            else
            {
                e.Cancel = true;
                qr_b.Focus();
                errorProvider.SetError(qr_b, "Please Enter a number!");

            }
        }

        private void Checkout_form_Load(object sender, EventArgs e)
        {
            //dt.Columns.Add("Id");
            //dt.Columns.Add("Name");
            //dataGridView1.DataSource = dt;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                qr_b.Text = "";
                total_b.Text = "";
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                cur_iteam = row.Cells[0].Value.ToString();
                item = row.Cells[1].Value.ToString();
                string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = con_str;
                con.Open();
                OracleCommand com = new OracleCommand();
                com.CommandText = "select * from inventory " + "WHERE inv_id = '" + cur_iteam + "'";
                com.Connection = con;
                com.CommandType = CommandType.Text;
                OracleDataReader dr = com.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    unit_price = dr.GetFloat(4) + dr.GetFloat(5);
                    available = dr.GetFloat(2);
                    if (avail_array.ContainsKey(cur_iteam))
                    {
                        qa_b.Text = avail_array[cur_iteam].ToString();
                    }
                    else
                    {
                        qa_b.Text = available.ToString();
                    }
                    cp_b.Text = unit_price.ToString();
                    meas_b.Text = dr.GetString(3);
                    sname_b.Text = dr.GetString(6);
                }
                con.Close();
            }
        }

        private void button_cart_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(qr_b.Text))
            {
                MessageBox.Show("Quantity required box is empty!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
            }
            else
            {
                if (bought_array.ContainsKey(cur_iteam))
                {
                    MessageBox.Show("Item is already is in the cart.\n Please delete it first", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                else
                {
                    avail_array[cur_iteam] = remain;
                    bought_array[cur_iteam] = float.Parse(qr_b.Text);
                    DataRow drow2 = dt2.NewRow();
                    drow2[0] = cur_iteam.ToString();
                    drow2[1] = item.ToString();
                    drow2[2] = meas_b.Text;
                    drow2[3] = cp_b.Text;
                    drow2[4] = qr_b.Text;
                    drow2[5] = total_b.Text;
                    drow2[6] = sname_b.Text;
                    dt2.Rows.Add(drow2);
                    qa_b.Text = avail_array[cur_iteam].ToString();
                    total_sale = total_sale + order_price;
                    total_lb.Text = total_sale.ToString();
                }
                


            }
        }

        private void search_b_TextChanged(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = con_str;
            con.Open();
            OracleCommand com = new OracleCommand();
            com.CommandText = "select * from inventory where inv_id like '" + search_b.Text + "%'"
                + "or name like '" + search_b.Text + "%'";
            com.Connection = con;
            com.CommandType = CommandType.Text;
            OracleDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                DataRow drow = dt.NewRow();
                drow[0] = dr.GetString(0).ToString();
                drow[1] = dr.GetString(1).ToString();
                dt.Rows.Add(drow);
                //MessageBox.Show(dr.GetString(0));
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(del_item))
            {
                MessageBox.Show("Please select the item to remove from cart!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                for (int i = dt2.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr2 = dt2.Rows[i];
                    if (dr2[0] == del_item)
                    {
                        total_sale = total_sale - float.Parse(dr2[5].ToString());
                        dr2.Delete();
                        avail_array[del_item] = avail_array[del_item] + bought_array[del_item];
                        bought_array.Remove(del_item);
                        total_lb.Text = total_sale.ToString();
                        qa_b.Text = "";
                        meas_b.Text = "";
                        cp_b.Text = "";
                        sname_b.Text = "";
                        qr_b.Text = "";
                        total_b.Text = "";
                        textBox1.Text = "";
                        tendered_lb.Text = "";
                        change_lb.Text ="";
                    }

                }
                dt2.AcceptChanges();
                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                del_item = row.Cells[0].Value.ToString();
            }
        }

        private void button_checkout_Click(object sender, EventArgs e)
        {
            string cname = cname_b.Text;
            string cadd = c_add_b.Text;
            string ccon = c_con_b.Text;
            string cart = cart_b.Text;
            float c_total = float.Parse(total_lb.Text);
            float c_tendered = float.Parse(tendered_lb.Text);
            float c_changed = float.Parse(change_lb.Text);
            DateTime d_t = DateTime.Parse(DateTime.Now.ToString("MMM dd yyyy,hh:mm:ss tt"));
            //DateTime d_t= DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            if (String.IsNullOrEmpty(cname) || String.IsNullOrEmpty(cadd) || String.IsNullOrEmpty(ccon) || String.IsNullOrEmpty(cart) || String.IsNullOrEmpty(total_lb.Text) || String.IsNullOrEmpty(change_lb.Text) || String.IsNullOrEmpty(tendered_lb.Text))
            {
                MessageBox.Show("Please fill all the required boxes first!", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Stop);
            }
            else
            {
                string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = con_str;
                con.Open();
                OracleCommand com = new OracleCommand();
                com.CommandText = "select cart_id from checkout where cart_id='" + cart + "'";
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
                    MessageBox.Show("Cart Id already exist! Please select a unique Id.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                    //textBox2.Focus();
                    cart_b.Text = "";
                }
                else if (count == 0)
                {
                    
                    if (dataGridView1.Rows.Count > 1)
                    {
                        qa_b.Text = "";
                        meas_b.Text = "";
                        cp_b.Text = "";
                        sname_b.Text = "";
                        qr_b.Text = "";
                        total_b.Text = "";
                        textBox1.Text = "";
                        tendered_lb.Text = "";
                        change_lb.Text = "";
                        total_lb.Text = "";
                        OracleCommand com2 = new OracleCommand();
                        com2.CommandText = "INSERT INTO CHECKOUT VALUES (:cart_id,:name,:contact, :p_d,:tot,:ten,:chng)";
                        com2.Parameters.Add("cart_id", cart);
                        com2.Parameters.Add("name", cname);
                        com2.Parameters.Add("contact", ccon);
                        com2.Parameters.Add("p_d", d_t);
                        com2.Parameters.Add("tot", c_total);
                        com2.Parameters.Add("ten", c_tendered);
                        com2.Parameters.Add("chng", c_changed);
                        com2.Connection = con;
                        com2.CommandType = CommandType.Text;
                        com2.ExecuteNonQuery();
                        OracleCommand com6 = new OracleCommand();
                        com6.CommandText = "select contact from customer where contact='" + "01944" + "'";
                        com6.Connection = con;
                        com6.CommandType = CommandType.Text;
                        OracleDataReader dr_c = com6.ExecuteReader();
                        int count2 = 0;
                        while (dr_c.Read())
                        {
                            
                            count2++;
                        }
                        if (count2 ==0)
                        {
                            OracleCommand com4 = new OracleCommand();
                            com4.CommandText = "INSERT INTO CUSTOMER VALUES (:cname,:ccontact,:caddress)";
                            com4.Parameters.Add("cname", cname);
                            com4.Parameters.Add("ccontact", ccon);
                            com4.Parameters.Add("caddress", cadd);
                            com4.Connection = con;
                            com4.CommandType = CommandType.Text;
                            com4.ExecuteNonQuery();
                        }
                        
                        for (int rows = 0; rows < dataGridView1.Rows.Count-1; rows++)
                        {
                            //string value = dataGridView1.Rows[rows].Cells[col].Value.ToString();
                            string c_it = dataGridView1.Rows[rows].Cells[0].Value.ToString();
                            string it_n = dataGridView1.Rows[rows].Cells[1].Value.ToString();
                            string mea = dataGridView1.Rows[rows].Cells[2].Value.ToString();
                            float cp = float.Parse(dataGridView1.Rows[rows].Cells[3].Value.ToString());
                            float qr = float.Parse(dataGridView1.Rows[rows].Cells[4].Value.ToString());
                            float tot = float.Parse(dataGridView1.Rows[rows].Cells[5].Value.ToString());
                            string sup = dataGridView1.Rows[rows].Cells[6].Value.ToString();
                                OracleCommand com3 = new OracleCommand();
                                com3.CommandText = "INSERT INTO TRANSACTION VALUES (:cart_id,:name,:iid,:inam,:qty,:meas,:p,:sup,:p_d,:contact)";
                            com3.Parameters.Add("cart_id", cart);
                            com3.Parameters.Add("name", cname);
                            com3.Parameters.Add("iid", c_it);
                            com3.Parameters.Add("inam", it_n);
                            com3.Parameters.Add("qty", qr);
                            com3.Parameters.Add("meas", mea);
                            com3.Parameters.Add("p", tot);
                            com3.Parameters.Add("sup", sup);
                            com3.Parameters.Add("p_d", d_t);
                            com3.Parameters.Add("contact", ccon);
                            com3.Connection = con;
                            com3.CommandType = CommandType.Text;
                            com3.ExecuteNonQuery();
                            OracleCommand com5 = new OracleCommand();
                            com5.CommandText = "update inventory set quantity =:q WHERE inv_id =:cid ";

                            com5.Parameters.Add("q", avail_array[c_it]);
                            com5.Parameters.Add("cid", c_it);
                            com5.Connection = con;
                            com5.CommandType = CommandType.Text;
                            com5.ExecuteNonQuery();
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Please add some items to cart first!", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
                    }
                }
            }
        }

        private void cart_b_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(cart_b.Text))
            {
                e.Cancel = true;
                cart_b.Focus();
                errorProvider.SetError(cart_b, "Please fill the form");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cart_b, "");
            }
        }

        private void cname_b_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(cname_b.Text))
            {
                e.Cancel = true;
                cname_b.Focus();
                errorProvider.SetError(cname_b, "Please fill the form");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cname_b, "");
            }
        }

        private void c_con_b_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(c_con_b.Text))
            {
                e.Cancel = true;
                c_con_b.Focus();
                errorProvider.SetError(c_con_b, "Please fill the form");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(c_con_b, "");
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider.SetError(textBox1, "Please fill the form");
            }
            else if(ten < total_sale)
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider.SetError(textBox1,"Tendered money is less than total money or invalid entry!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox1, "");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int x = 0;
            float y = 0;
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                change_lb.Text = "";
                tendered_lb.Text = "";
            }
            else if (Int32.TryParse(textBox1.Text, out x) || float.TryParse(textBox1.Text, out y))
            {
                 ten = float.Parse(textBox1.Text);
                tendered_lb.Text = ten.ToString();
                if (ten >= total_sale)
                {
                     c = ten - total_sale;
                    change_lb.Text = c.ToString();
                    tendered_lb.Text = ten.ToString();
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number number!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);

            }
        }
    }
}
