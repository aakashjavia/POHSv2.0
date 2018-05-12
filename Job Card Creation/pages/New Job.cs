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
    public partial class NewJob : UserControl
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
                StatusLabel1.Text = "Status: - Data Accepted";
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: -" + err.Message);
            }
        }
        public void updatedata()
        {
            try
            {


                SqlCommand cmd = new SqlCommand();
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                cmd.CommandType = System.Data.CommandType.Text;
                //     cmd.CommandText = "select sr_no, item_code, name, party_name from job_info where sr_no >0";
                cmd.CommandText = "select * from job_info where sr_no >0";
                cmd.Connection = con;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
                dataGridView1.Font = new Font("Seguo UI", 8F, GraphicsUnit.Point);
                StatusLabel1.Text = "Status: - Data Filled";
                fill_sr_no();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: - " + err.Message);
            }

        }
        private void NewJob_Load(object sender, EventArgs e)
        {
           
            try
            {

                fill_sr_no();
                updatedata();
                //For AutoComplete
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                SqlConnection con;
                con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                paper_type.AutoCompleteMode = AutoCompleteMode.Suggest;
                paper_type.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                // Retrieve all rows
                cmd.CommandText = "SELECT * FROM Inventory";
                cmd.Connection = con;
                con.Open();

                using (var read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        collection.Add(read["paper_type"].ToString());
                    }
                }
                paper_type.AutoCompleteCustomSource = collection;
                con.Close();
              
                Color backcolor = new Color();
                backcolor = Color.LightYellow;
               // backcolor = this.BackColor;           
                                
             



            }
            catch (Exception err)
            {
                MessageBox.Show("Error: - " + err.Message);
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
                    StatusLabel1.Text = "Status: -Number Filled";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: - " + err.Message);
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


        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void paper_type_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void paper_type_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                
                SqlConnection con;
                con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select paper_size from inventory where paper_type = '" + paper_type.Text + "'";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sheet_size.Text = reader.GetString(0);
                }
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: - " + err.Message);
            }
        }
        private void color_shades_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    sr_no.Text = row.Cells[0].Value.ToString();
                    item_code.Text = row.Cells[1].Value.ToString();
                    name.Text = row.Cells[2].Value.ToString();
                    party_name.Text = row.Cells[3].Value.ToString();
                    size.Text = row.Cells[4].Value.ToString();
                    paper_type.Text = row.Cells[5].Value.ToString();
                    sheet_size.Text = row.Cells[6].Value.ToString();
                    cutting_size.Text = row.Cells[7].Value.ToString();
                    num_of_colors.Text = row.Cells[8].Value.ToString();
                    color_shades.Text = row.Cells[9].Value.ToString();
                    varnish.Text = row.Cells[10].Value.ToString();

                }
                StatusLabel1.Text = "Status: - Filled";
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: - " + err.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                SqlConnection con;
                con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
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
                con.Open();
                int r_affected = cmd.ExecuteNonQuery();
                StatusLabel1.Text = "Status: - Rows Affected: -" + r_affected;
                con.Close();
                updatedata();
                fill_sr_no();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: - " + err.Message);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                int rows;
                cmd.CommandText = "UPDATE job_info SET " +
                "item_code = @item_code," +
                "name = @name," +
                "party_name = @party_name,"+
                "size = @size," +
                "paper_type = @paper_type," +
                "sheet_size = @sheet_size," +
                "cutting_size = @cutting_size," +
                "num_of_colors = @num_of_colors," +
                "color_shades = @color_shades," +
                "varnish = @varnish "+
                " where sr_no = @sr_no";
                cmd.Parameters.AddWithValue("@item_code", item_code.Text);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@party_name", party_name.Text);
                cmd.Parameters.AddWithValue("@size", size.Text);
                cmd.Parameters.AddWithValue("@paper_type", paper_type.Text);
                cmd.Parameters.AddWithValue("@sheet_size", sheet_size.Text);
                cmd.Parameters.AddWithValue("@cutting_size", cutting_size.Text);
                cmd.Parameters.AddWithValue("@num_of_colors", num_of_colors.Text);
                cmd.Parameters.AddWithValue("@color_shades", color_shades.Text);
                cmd.Parameters.AddWithValue("@varnish", varnish.Text);
                cmd.Parameters.AddWithValue("@sr_no", sr_no.Text);
              

                con.Open();
                rows = cmd.ExecuteNonQuery();
                StatusLabel1.Text = "Status: - Rows Affected (" + rows.ToString() + ")";
                updatedata();
                fill_sr_no();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: - " + err.Message);
            }
        }
    }
}