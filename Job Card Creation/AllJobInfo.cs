using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Job_Card_Creation
{
    public partial class AllJobInfo : UserControl
    {
        public AllJobInfo()
        {
            InitializeComponent();
        }

        public void updatedata()
        {
            SqlCommand cmd = new SqlCommand();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select item_code, name, party_name, paper_type from job_info where sr_no >0";
            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Font = new Font("Seguo UI", 8F, GraphicsUnit.Point);
        }

        private void AllJobInfo_Load(object sender, EventArgs e)
        {
            try
            {
                updatedata();
                dataGridView1.BackgroundColor = this.BackColor;
            }
            catch(Exception err)
            {
                StatusLabel.Text = "STATUS: - " + err.Message;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
