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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        public void Report1(CrystalReport2 cr)
        {
            crystalReportViewer1.ReportSource = cr;
        }
        public void Report2(CrystalReport1 cr)
        {
            crystalReportViewer1.ReportSource = cr;
        }
        private void Report_Load(object sender, EventArgs e)
        {
            //crystalReportViewer1.ReportSource = "";
        }
    }
}
