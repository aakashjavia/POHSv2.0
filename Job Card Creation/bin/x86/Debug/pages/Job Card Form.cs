using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing;
using System.Globalization;
using System.Data.SqlClient;


namespace Job_Card_Creation
{
    public partial class JobCard : UserControl
    {
        private Button button2 = new Button();
  

        public JobCard()
        {
            InitializeComponent();
           
          
        }      
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //Autofill with new Number
            try
            {
                int sr = 0;
                
                SqlCommand cmd = new SqlCommand();
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

                SqlConnection con = new SqlConnection(connectionString);
                cmd.CommandType = System.Data.CommandType.Text;
                
                cmd.Connection = con;
                con.Open();
                //For AutoComplete
                item_code.AutoCompleteMode = AutoCompleteMode.Suggest;
                item_code.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                // Retrieve all rows
                cmd.CommandText = "SELECT * FROM job_info";
                
                
                using (var read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        collection.Add(read["item_code"].ToString());
                    }
                }
                item_code.AutoCompleteCustomSource = collection;


                cmd.CommandText = "select * from job_card order by sr_no desc";                
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    sr = reader.GetInt32(0) + 1;
                    sr_no.Text = sr.ToString();
                    StatusLabel.Text = "Status: -Number Filled";
                }
                con.Close();
            }
                
            
            catch (Exception err)
            {
                MessageBox.Show("Error: - " + err.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int r_affected,sr;
              
                SqlCommand cmd = new SqlCommand();
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);

                cmd.CommandType = System.Data.CommandType.Text;
              
                cmd.Connection = con;
                
                cmd.CommandText = "INSERT INTO job_card VALUES ('"
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
                    + varnish.Text + "','"
                    + date.Text + "','"
                    + printer_name.Text + "','"
                    + gross_packets.Text + "','"
                    + no_of_sheets.Text + "','"
                    + ups_per_sheet.Text + "','"
                    + print_front.Text + "','"
                    + print_waste.Text + "','"
                    + print_total.Text + "','"
                    + paper_from.Text + "')";
                cmd.Connection = con;
                con.Open();
               r_affected=cmd.ExecuteNonQuery();
                con.Close();
                
                //Filling order_status table here
                    //Getting Sr NO
                cmd.CommandText = "select * from order_status order by sr_no desc";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();                
                sr = reader.GetInt32(0) + 1;
                con.Close();

                
                //Fills Current date automatically    
                DateTime today = DateTime.Today;
                string s = today.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);

                //Filling Data
                
                cmd.CommandText = "INSERT INTO order_status VALUES ('"
                    + sr.ToString() + "','"
                    + item_code.Text + "','"
                    + name.Text + "','"
                    + party_name.Text + "','"
                    + date.Text + "','"
                    + s + "', NULL, NULL, NULL)";
                
                con.Open();
                cmd.ExecuteNonQuery();

                con.Close();
                StatusLabel.Text = "Status: - Data Accepted (" + r_affected.ToString()+ ") ";
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: -" + err.Message);
            }
            
         
        }

        private void JobCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
              
                SqlCommand cmd = new SqlCommand();
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
               
               
                
             
                cmd.CommandText = "select * from job_info where item_code = '" + this.item_code.Text + "'";
                con.Open();


               
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.name.Text = reader.GetString(2);
                    this.party_name.Text = reader.GetString(3);
                    this.size.Text = reader.GetString(4);
                    this.paper_type.Text = reader.GetString(5);
                    this.sheet_size.Text = reader.GetString(6);
                    this.cutting_size.Text = reader.GetString(7);
                    this.num_of_colors.Text = reader.GetString(8);
                    this.color_shades.Text = reader.GetString(9);
                    this.varnish.Text = reader.GetString(10);
                    StatusLabel.Text = "Status: - Data Filled";
                }
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: -" + err.Message);
            }
        }
      public void label2_Click_(object sender, EventArgs e)
        {

        }

      

        private void DateLabel_Click(object sender, EventArgs e)
        {
            //Fills Current date automatically, and makes date picker visible
            dateTimePicker1.Visible = true;
            date.Text = dateTimePicker1.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Fills date time Manually
            date.Text = dateTimePicker1.Text;
            dateTimePicker1.Visible = false;
        }

        private void navigationBar1_Load(object sender, EventArgs e)
        {

        }  

        private void NewJob_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewJob frm2 = new NewJob();
            frm2.Show();
        }

        private void JobCardLabel_Click(object sender, EventArgs e)
        {

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

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void FrontPrintLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
