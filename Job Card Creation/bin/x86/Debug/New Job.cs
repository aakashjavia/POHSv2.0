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
            this.StartPosition = FormStartPosition.Manual;
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
                StatusLabel.Text = "STATUS:- Data Accepted";
            }
            catch (Exception err)
            {
                StatusLabel.Text = "STATUS:-" + err.Message;
            }
        }

        private void NewJob_Load(object sender, EventArgs e)
        {
           
            try
            {
               
                fill_sr_no();
                fillComboBox();
            }
            catch (Exception err)
            {
                StatusLabel.Text = "STATUS:-" + err.Message;
            }
        }
        //ComboBoxItem
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        public void fillComboBox()
        {
            try
            {
                ComboboxItem item = new ComboboxItem();

                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                SqlConnection con;
                con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Inventory";
                cmd.Connection = con;
                con.Open();
                using (var read = cmd.ExecuteReader())
                {
                    int count = 0;
                    while (read.Read())
                    {
                        count = count + 1;
                        item.Text = read["paper_type"].ToString();
                        item.Value = read["paper_type"].ToString();
                        paper_type.Items.Add(item);
                    }
                    paper_type.SelectedIndex = 0;
                }
                con.Close();
            }
            catch (Exception err)
            {
                StatusLabel.Text = "STATUS: -" + err.Message;
            }
        }
        public void fill_sr_no()
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                int sr;
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
                    StatusLabel.Text = "STATUS:-Number Filled";
                }
            }
            catch (Exception err)
            {
                StatusLabel.Text = "STATUS: -" + err.Message;
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

        private void paper_type_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void NewJob_Click(object sender, EventArgs e)
        {
          
        }

        private void JobCardLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            JobCard frm1 = new JobCard();
            frm1.Show();
        }

        private void InventoryLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory frm3 = new Inventory();
            frm3.Show();
        }

        private void OrderLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderStatus frm4 = new OrderStatus();
            frm4.Show();
        }

        private void n(object sender, EventArgs e)
        {

        }
    }
}