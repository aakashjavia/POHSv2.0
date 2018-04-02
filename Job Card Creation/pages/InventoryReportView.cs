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
            try { 
            SqlCommand cmd = new SqlCommand();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "select * from Inventory";
            ReportDocument invReport = new ReportDocument();
            invReport.Load(@"G:\RPNP Databases\VISUAL STUDIO\Repositories\POHSv2.0\Job Card Creation\reports\InventoryReport.rpt");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Inventory");
            invReport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = invReport;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.Zoom(75);
            zoom_var.Text = "75";
            }
            catch (Exception err)
            {
                MessageBox.Show("Error(crystalReportViewer1_Load): -" + err.Message);
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
            invReport.Load(@"G:\RPNP Databases\VISUAL STUDIO\Repositories\POHSv2.0\Job Card Creation\reports\InventoryReport.rpt");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Inventory");
            invReport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = invReport;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.Zoom(75);
            zoom_var.Text = "75";
            
            }
            catch (Exception err)
            {
                MessageBox.Show("Error(FieldSelectButton_Click): -" + err.Message);
            }

        }

        private void FieldListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
 
        }

        private void TotalUsageButton_Click(object sender, EventArgs e)
        {
            try
            {              
 

            }
            catch (Exception err)
            {
                MessageBox.Show("Error(TotalUsageButton_Click): -" + err.Message);
            }
        }

        private void StatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ZoomInButton_Click(object sender, EventArgs e)
        {
            try
            {
              
                    int zoom = Convert.ToInt32(zoom_var.Text);
                if (zoom < 400)
                {
                    zoom = zoom + 25;
                    zoom_var.Text = zoom.ToString();
                    crystalReportViewer1.Zoom(zoom);
                }
                else
                {
                    zoom = 400;
                    zoom_var.Text = zoom.ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error(FieldSelectButton_Click): -" + err.Message);
            }
        }

        private void ZoomOutButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                int zoom = Convert.ToInt32(zoom_var.Text);
                if (zoom > 25)
                {
                    zoom = zoom - 25;
                    zoom_var.Text = zoom.ToString();
                    crystalReportViewer1.Zoom(zoom);
                }
                else
                {
                    zoom = 25;
                    zoom_var.Text = zoom.ToString();
                }
            }
               catch (Exception err)
            {
                MessageBox.Show("Error(FieldSelectButton_Click): -" + err.Message);
            }
        }
    }
}
