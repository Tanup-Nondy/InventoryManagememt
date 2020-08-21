using DGVPrinterHelper;
using Microsoft.Office.Interop.Excel;
using Oracle.ManagedDataAccess.Client;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Transaction_report_form : Form
    {
        int invr = 0;
        int tranr = 0;
        public Transaction_report_form()
        {
            InitializeComponent();
            /*string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = con_str;
            con.Open();
            OracleCommand com = new OracleCommand();
            com.CommandText = "select * from transaction";
            com.Connection = con;
            com.CommandType = CommandType.Text;
            OracleDataReader dr = com.ExecuteReader();
            System.Data.DataTable table = new System.Data.DataTable();
            table.Load(dr);
            dataGridView1.DataSource = table;*/

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
           
  
            // creating Excel Application  
             Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
             // creating new WorkBook within Excel application  
             Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
             // creating new Excelsheet in workbook  
             Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            Microsoft.Office.Interop.Excel.Range range= null;
             // see the excel sheet behind the program  
             app.Visible = true;
             // get the reference of first sheet. By default its name is Sheet1.  
             // store its reference to worksheet  
             worksheet = workbook.Sheets["Sheet1"];
             worksheet = workbook.ActiveSheet;
             // changing the name of active sheet  
             worksheet.Name = "Exported from gridview";
            
             // storing header part in Excel  
             for (int i = 1; i < dataGridView1.Columns.Count+1 ; i++)
             {
                range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[4, i ];
                
                range.Value2 = dataGridView1.Columns[i-1].HeaderText;
                range.Cells[1].ColumnWidth = 20;
               // worksheet.Cells[1, i] = dataGridView1.Columns[i-1].HeaderText;
             }
            //Console.WriteLine(dataGridView1[8, 0].Value.ToString());
             // storing Each row and column value to excel sheet  
             for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
             {
                 for (int j = 0; j < dataGridView1.Columns.Count; j++)
                 {
                    
                        range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[i + 5, j + 1];
                    range.NumberFormat = "@";
                    range.Value2 = dataGridView1[j, i].Value.ToString();
        
                 }
             }
             // save the application  
             workbook.SaveAs("F:\\CSharp Code\\InventoryManagement\\Output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
             // Exit from the application  
             app.Quit();
            
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            /* DataSet ds = new DataSet();
             System.Data.DataTable dt = new System.Data.DataTable();


             foreach (DataGridViewRow item in this.dataGridView1.Rows)
             {

                 DataRow dr = dt.NewRow();

                 if (item.DataBoundItem != null)
                 {
                     dr = (DataRow)((DataRowView)item.DataBoundItem).Row;
                     dt.ImportRow(dr);
                 }
             }

             ds.Tables.Add(dt);
            */
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Inventory Report";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Inventory";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView1);
            invr = 1;
        }

        private void button_tran_Click(object sender, EventArgs e)
        {
            string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = con_str;
            con.Open();
            OracleCommand com = new OracleCommand();
            com.CommandText = "select * from transaction";
            com.Connection = con;
            com.CommandType = CommandType.Text;
            OracleDataReader dr = com.ExecuteReader();
            System.Data.DataTable table = new System.Data.DataTable();
            table.Load(dr);
            dataGridView1.DataSource = table;
            tranr = 1;
        }

        private void button_Inv_Click(object sender, EventArgs e)
        {
            string con_str = "DATA SOURCE=localhost:1521/orcl;USER ID=HR;password=hr";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = con_str;
            con.Open();
            OracleCommand com = new OracleCommand();
            com.CommandText = "select * from inventory";
            com.Connection = con;
            com.CommandType = CommandType.Text;
            OracleDataReader dr = com.ExecuteReader();
            System.Data.DataTable table = new System.Data.DataTable();
            table.Load(dr);
            dataGridView1.DataSource = table;
            invr = 1;
        }

        private void button_crystal_Click(object sender, EventArgs e)
        {
            Console.WriteLine(invr + " \n" + tranr);
            if (tranr == 1)
            {
                DataSet ds_inv = new DataSet();
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.Add("Cart_Id", typeof(string));
                dt.Columns.Add("Customer", typeof(string));
                dt.Columns.Add("Item_ID", typeof(string));
                dt.Columns.Add("Item_Name", typeof(string));
                dt.Columns.Add("quantity", typeof(string));
                dt.Columns.Add("Measurement", typeof(string));
                dt.Columns.Add("Price", typeof(string));
                dt.Columns.Add("Supplier", typeof(string));
                dt.Columns.Add("Date", typeof(string));
                dt.Columns.Add("Contact", typeof(string));
                foreach (DataGridViewRow dgv in dataGridView1.Rows)
                {
                    dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value, dgv.Cells[6].Value, dgv.Cells[7].Value, dgv.Cells[8].Value, dgv.Cells[9].Value);

                }
                ds_inv.Tables.Add(dt);
                ds_inv.WriteXmlSchema("SampleInventory.xml");
                foreach (System.Data.DataTable table in ds_inv.Tables)
                {
                    Console.WriteLine("x\n");
                    foreach (DataRow dr in table.Rows)
                    {
                        Console.WriteLine("y\n");
                        Console.Write(dr[0]);
                        Console.Write(dr[1]);
                        Console.Write(dr[2]);
                        Console.Write(dr[3]);
                        Console.Write(dr[4]);
                        Console.Write(dr[5]);
                        Console.Write(dr[6]);
                        Console.Write(dr[7]);
                        Console.Write(dr[8]);
                        Console.Write(dr[9]);
                    }
                }
                CrystalReport1 cr = new CrystalReport1();
                cr.SetDataSource(ds_inv);
                Report rf = new Report();
                rf.Report2(cr);
                rf.Show();
                invr = 0;
            }
            if (tranr == 1)
            {
                DataSet ds_tr = new DataSet();
                System.Data.DataTable dtt = new System.Data.DataTable();
                dtt.Columns.Add("Inv_Id", typeof(string));
                dtt.Columns.Add("Name", typeof(string));
                dtt.Columns.Add("Quantity", typeof(string));
                dtt.Columns.Add("Measurement", typeof(string));
                dtt.Columns.Add("Original Price", typeof(string));
                dtt.Columns.Add("increased Price", typeof(string));
                dtt.Columns.Add("Supplier", typeof(string));
                foreach (DataGridViewRow dgv in dataGridView1.Rows)
                {
                    dtt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2]);
                }
                ds_tr.Tables.Add(dtt);
                ds_tr.WriteXmlSchema("SampleTransaction.xml");
                CrystalReport2 cr = new CrystalReport2();
                cr.SetDataSource(ds_tr);
                Report rf = new Report();
                rf.Report1(cr);
                rf.ShowDialog();
                tranr = 0;
            }
        }
    }
}
