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
    public partial class Form1 : Form
    {
        public static string uname = "";
        private int login_user = 0;
        private int login_admin = 0;
        public Form1(string name)
        {
            InitializeComponent();
            timer1.Start();
            uname = name;
        }
        
        login_form form2 = new login_form();
        public static Label label = new Label();
        private void login_menu_Click(object sender, EventArgs e)
        {
            if (form2.ShowDialog() == DialogResult.OK)
            {
                login_user = 1;
                logoutToolStripMenuItem.Enabled = true;
                login_menu.Enabled = false;
                adminToolStripMenuItem.Enabled = false;
                suppliersToolStripMenuItem.Enabled=true;
                inventoryToolStripMenuItem.Enabled = true;
                checkoutToolStripMenuItem.Enabled = true;
                transactionsToolStripMenuItem.Enabled = true;
                historyToolStripMenuItem.Enabled = true;
                label1.Text = "You are currently logged in as " + uname;
            }
            //login_form login = new login_form();
            //login.Show();
        }
       
        public static ToolStripMenuItem sup,inv,cho,tran,his=new ToolStripMenuItem();

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier_form form_s = new Supplier_form();
            form_s.ShowDialog();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory_form inventory_Form = new Inventory_form();
            inventory_Form.ShowDialog();
        }

        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checkout_form cform = new Checkout_form();
            cform.ShowDialog();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction_form tf = new Transaction_form();
            tf.ShowDialog();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction_report_form rf = new Transaction_report_form();
            rf.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login_user == 1)
            {
                login_user = 0;
            }
            if (login_admin == 1)
            {
                login_admin = 0;
            }
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "Form1")
                    f.Close();
            }
            login_menu.Enabled = true;
            adminToolStripMenuItem.Enabled = true;
            logoutToolStripMenuItem.Enabled = false;
            suppliersToolStripMenuItem.Enabled = false;
            inventoryToolStripMenuItem.Enabled = false;
            checkoutToolStripMenuItem.Enabled = false;
            transactionsToolStripMenuItem.Enabled = false;
            historyToolStripMenuItem.Enabled = false;
            label1.Text = "Please login first to access all of the options!";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_form ad = new Admin_form();
            if (ad.ShowDialog() == DialogResult.OK)
            {
                login_admin = 1;
                login_menu.Enabled = false;
                adminToolStripMenuItem.Enabled = false;
                logoutToolStripMenuItem.Enabled = true;
                suppliersToolStripMenuItem.Enabled = true;
                inventoryToolStripMenuItem.Enabled = true;
                checkoutToolStripMenuItem.Enabled = true;
                transactionsToolStripMenuItem.Enabled = true;
                historyToolStripMenuItem.Enabled = true;
                label1.Text = "You are currently logged in as Admin";
                Add_user form = new Add_user();
                form.ShowDialog();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {
            sup = suppliersToolStripMenuItem;
            inv = inventoryToolStripMenuItem;
            cho = checkoutToolStripMenuItem;
            tran = transactionsToolStripMenuItem;
            his = historyToolStripMenuItem;
            label = label1;
        }
    }
}
