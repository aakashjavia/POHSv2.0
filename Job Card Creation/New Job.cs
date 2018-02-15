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
namespace Job_Card_Creation
{
    public partial class NewJob : Form
    {
        public NewJob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {              
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                //Database Connection and insertion
                SqlConnection con;
                con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "INSERT INTO job_info VALUES ('"
                    + sr_no.Text + "','"
                    + item_code.Text + "','"
                    + name.Text + "','"
                    + party_name.Text + "','"
                    + size.Text + "','"
                    + paper_type.Text + "','"
                    + sheet_size.Text + "','"
                    + cutting_size.Text + "','"
                    + num_of_colors.Text + "','"
                    + color_shades.Text + "','"
                    + varnish.Text + "')";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                StatusLabel.Text = "STATUS(button1_Click):- Data Accepted";
            }
            catch (Exception err)
            {
                StatusLabel.Text = "STATUS(button1_Click):-" + err.Message;
            }
        }

        private void NewJob_Load(object sender, EventArgs e)
        {
            try
            {
                int sr = 0;
                //AutoFill Sr. No
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

                SqlConnection con;
                con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from job_info order by sr_no desc";
                cmd.Connection = con;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    sr = reader.GetInt32(0) + 1;
                    sr_no.Text = sr.ToString();
                    StatusLabel.Text = "STATUS(Form1_Load):-Number Filled";
                }
            }
            catch (Exception err)
            {
                StatusLabel.Text = "STATUS(Form1_Load):-" + err.Message;
            }
        }

        private void sr_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void paper_type_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void party_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void SheetCuttingLabel_Click(object sender, EventArgs e)
        {

        }
    }
}