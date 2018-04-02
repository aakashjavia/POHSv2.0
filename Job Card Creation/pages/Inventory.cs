using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

using Job_Card_Creation.pages;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Util;


namespace Job_Card_Creation
{
    public partial class Inventory : UserControl
    {

        public Inventory()
        {
            InitializeComponent();
            
        }
        


        private void Inventory_Load(object sender, EventArgs e)
        {
            try
            {
                updatedata();
                inventoryCheck();
                dataGridView1.BackgroundColor = this.BackColor;
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: -" + err.Message);
            }
        }
        public void updatedata()
        {
            SqlCommand cmd = new SqlCommand();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Inventory where sr_no >0";
            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Font = new Font("Seguo UI", 8F, GraphicsUnit.Point);

        }
        public void update_sr_no()
        {
            SqlCommand cmd = new SqlCommand();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;

            cmd.CommandText = "select * from inventory order by sr_no desc";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int sr = reader.GetInt32(0) + 1;
            sr_no.Text = sr.ToString();
            con.Close();
        }
        public void inventoryCheck()
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand();
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM Inventory where sheets <= threshold and sr_no > 0";
               
                string alertstring = null;
                cmd.Connection = con;
                con.Open();
                using (var read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        alertstring += "\n " + read.GetValue(1);
                    }
                    if (alertstring != null)
                    {
                        MessageBox.Show("The following paper types are at or below critical levels: -" +
                            "" + alertstring + "\n Please take necessary action");
                    }
                    con.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: -" + err.Message);
            }
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                StatusLabel.Text = "Status: - Clicked";
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    sr_no.Text = row.Cells[0].Value.ToString();
                    paper_type.Text = row.Cells[1].Value.ToString();
                    paper_size.Text = row.Cells[2].Value.ToString();
                    packets.Text = row.Cells[3].Value.ToString();
                    sheets.Text = row.Cells[4].Value.ToString();
                    threshold.Text = row.Cells[5].Value.ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: -" + err.Message);
            }
        }
                private void paper_type_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            { 
            SqlCommand cmd = new SqlCommand();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;
            int rows;

            cmd.CommandText = "UPDATE inventory SET " +
            "paper_type = @paper_type," +
            "paper_size = @paper_size," +
            "packets = @packets," +
            "sheets = @sheets, " +
            "threshold = @threshold" +
             " where sr_no = @sr_no";

                cmd.Parameters.AddWithValue("@paper_type", paper_type.Text);
                cmd.Parameters.AddWithValue("@paper_size", paper_size.Text);
                cmd.Parameters.AddWithValue("@packets", packets.Text);
                cmd.Parameters.AddWithValue("@sheets", sheets.Text);
                cmd.Parameters.AddWithValue("@threshold", threshold.Text);
                cmd.Parameters.AddWithValue("@sr_no", sr_no.Text);

            con.Open();
            rows = cmd.ExecuteNonQuery();
            StatusLabel.Text = "Status: -Rows Affected: -" + rows.ToString();
            updatedata();
            inventoryCheck();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: -" + err.Message);
            }


        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                update_sr_no();
                SqlCommand cmd = new SqlCommand();
              string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
              SqlConnection con = new SqlConnection(connectionString);
              cmd.CommandType = System.Data.CommandType.Text;
              cmd.Connection = con;
                
                cmd.CommandText = "insert into inventory values ('"
               + sr_no.Text + "','"
               + paper_type.Text + "','"
               + paper_size.Text + "','"
              + packets.Text + "','"
              + sheets.Text + "', '" 
              + threshold.Text +"')";

                con.Open();
              int rows = cmd.ExecuteNonQuery();
              StatusLabel.Text = "Status: -Rows Affected: -" + rows.ToString();
              con.Close();
              updatedata();
              inventoryCheck();
               
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: -" + err.Message);
            }

        }

        private void txtSrNo_OnClick(object sender, EventArgs e)
        {
           
        }

        private void sr_no_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void threshold_TextChanged(object sender, EventArgs e)
        {

        }

        private void BasicReportButton_Click(object sender, EventArgs e)
        {
            InventoryReportView invRep = new InventoryReportView();
            invRep.Show();       

        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            
        }

        private void UsageButton_Click(object sender, EventArgs e)
        {
            try
            {            
                SqlCommand cmd = new SqlCommand();
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select paper_type, SUM(no_of_sheets) AS total from job_card GROUP BY paper_type";
                cmd.Connection = con;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
                dataGridView1.Font = new Font("Seguo UI", 8F, GraphicsUnit.Point);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: -" + err.Message);
            }
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            updatedata();
        }
    }
}