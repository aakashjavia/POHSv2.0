using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
            try
            {
                SqlCommand cmd = new SqlCommand();
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "select * from Inventory";
                ReportDocument invReport = new ReportDocument();
                invReport.Load(@"F:\archie\POHSv2.0\Job Card Creation\reports\InventoryReport.rpt");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Inventory");
                invReport.SetDataSource(ds);
                crystalReportViewer1.ReportSource = invReport;
                crystalReportViewer1.Refresh();
                crystalReportViewer1.Zoom(75);
                /*   invReport.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"G:\RPNP Databases\VISUAL STUDIO\Repositories\POHSv2.0\Job Card Creation\saved_reports\Inventory.pdf");

                   MessageBox.Show("Exported Successful");
                   ProcessStartInfo viewfile = new ProcessStartInfo("explorer.exe");
                   viewfile.WindowStyle = ProcessWindowStyle.Minimized;
                   viewfile.Arguments = @"";
                   Process.Start(viewfile);*/
            }
            catch(Exception err)
            {
                StatusLabel1.Text = "Status: - " + err.Message;
            }
        }
        
        private void InventoryReportView_Load(object sender, EventArgs e)
        {

        }

        private void FieldSelectButton_Click(object sender, EventArgs e)
        {
            try { 
            string fields = "paper_type, sheets, threshold";
            if (FieldListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                fields = fields + ", sr_no";
            }     
            if (FieldListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                fields = fields + ", paper_size";
            }
            if (FieldListBox1.GetItemCheckState(2) == CheckState.Checked)
            {
                fields = fields + ", packets";
            }
     
            StatusLabel1.Text = "Status: -"+ fields ;
            SqlCommand cmd = new SqlCommand();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "select "+ fields + " from Inventory";
            ReportDocument invReport = new ReportDocument();
            invReport.Load(@"F:\archie\POHSv2.0\Job Card Creation\reports\InventoryReport.rpt");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Inventory");
            invReport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = invReport;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.Zoom(75);
            
            }
            catch (Exception err)
            {
               StatusLabel1.Text = "Status: - " + err.Message;
            }

        }

        private void FieldListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
