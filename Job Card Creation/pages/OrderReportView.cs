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
    public partial class OrderReportView : Form
    {
        public OrderReportView()
        {
            InitializeComponent();
        }

        private void OrderReportView_Load(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "select * from order_status";
                ReportDocument ordReport = new ReportDocument();
                ordReport.Load(@"G:\RPNP Databases\VISUAL STUDIO\Repositories\POHSv2.0\Job Card Creation\reports\OrderReport.rpt");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds, "order_status");
                ordReport.SetDataSource(ds);
                crystalReportViewer1.ReportSource = ordReport;
                crystalReportViewer1.Refresh();
                crystalReportViewer1.Zoom(75);
                /*   ordReport.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"G:\RPNP Databases\VISUAL STUDIO\Repositories\POHSv2.0\Job Card Creation\saved_reports\Inventory.pdf");

                   MessageBox.Show("Exported Successful");
                   ProcessStartInfo viewfile = new ProcessStartInfo("explorer.exe");
                   viewfile.WindowStyle = ProcessWindowStyle.Minimized;
                   viewfile.Arguments = @"";
                   Process.Start(viewfile);*/
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: - " + err.Message);
            }
        }

        private void StatusReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                string status = "";

                foreach (RadioButton rdo in StatusGroup.Controls.OfType<RadioButton>())
                {
                    if (rdo.Checked)
                    {
                        status = rdo.Text;
                    }
                }




                SqlCommand cmd = new SqlCommand();
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "select * from order_status where status ='" + status + "'";
                ReportDocument ordReport = new ReportDocument();
                ordReport.Load(@"G:\RPNP Databases\VISUAL STUDIO\Repositories\POHSv2.0\Job Card Creation\reports\OrderReport.rpt");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds, "order_status");
                ordReport.SetDataSource(ds);
                crystalReportViewer1.ReportSource = ordReport;
                crystalReportViewer1.Refresh();
                crystalReportViewer1.Zoom(75);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: - " + err.Message);
            }
        }

        private void PriorityReportButton_Click(object sender, EventArgs e)
        {
            string priority = "";
            foreach (RadioButton rdo in PriorityGroup.Controls.OfType<RadioButton>())
            {

                if (rdo.Checked)
                {
                    priority = rdo.Text;
                }
            }
            SqlCommand cmd = new SqlCommand();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "select * from order_status where priority ='" + priority + "'";
            ReportDocument ordReport = new ReportDocument();
            ordReport.Load(@"G:\RPNP Databases\VISUAL STUDIO\Repositories\POHSv2.0\Job Card Creation\reports\OrderReport.rpt");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "order_status");
            ordReport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = ordReport;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.Zoom(75);
        }
    }
}

