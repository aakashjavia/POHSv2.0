using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Job_Card_Creation.pages
{
    public partial class InventoryReportView : Form
    {
        public InventoryReportView()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "select paper_type, paper_size, sheets, threshold from Inventory";
            ReportDocument invReport = new ReportDocument();
            invReport.Load(@"G:\RPNP Databases\VISUAL STUDIO\Repositories\POHSv2.0\Job Card Creation\reports\InventoryReport.rpt");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Inventory");
            invReport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = invReport;
            crystalReportViewer1.Refresh();

            invReport.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"G:\RPNP Databases\VISUAL STUDIO\Repositories\POHSv2.0\Job Card Creation\saved_reports\Inventory.pdf");

            MessageBox.Show("Exported Successful");
        }
    }
}
