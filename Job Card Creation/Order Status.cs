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

namespace Job_Card_Creation
{
    public partial class OrderStatus : Form
    {
        public OrderStatus()
        {
            InitializeComponent();
        }

        private void OrderStatus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.order_status' table. You can move, or remove it, as needed.
            try
            {
                SqlCommand cmd = new SqlCommand();
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from order_status order by date desc";
                cmd.Connection = con;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
            }
            catch (Exception err)
            {
                StatusLabel.Text = "STATUS(OrderStatus_Load):-" + err.Message;
            }
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void PriorityLabel_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioImmediate_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
