using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Card_Creation
{
    public partial class OrderStatus : UserControl
    {
        public OrderStatus()
        {
            InitializeComponent();
           
        }

        private void OrderStatus_Load(object sender, EventArgs e)
        {
               try
            {
                //Fills Current date automatically    
                DateTime today = DateTime.Today;
                string s = today.ToString("dd MMMM yyyy", CultureInfo.InvariantCulture);
                date.Text = s;
                updatedata();
                dataGridView1.BackgroundColor = this.BackColor;
                
            }
            catch (Exception err)
            {
                StatusLabel.Text = "Status: -" + err.Message;
            }
        }
        public void updatedata()
        {
            SqlCommand cmd = new SqlCommand();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from order_status where sr_no >0 order by date desc";
            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Font = new Font("Seguo UI", 8F, GraphicsUnit.Point);

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
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void radioImmediate_CheckedChanged(object sender, EventArgs e)
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
                    var_status.Text = row.Cells[6].Value.ToString();
                    var_priority.Text = row.Cells[7].Value.ToString();
                    Comments.Text = row.Cells[8].Value.ToString();

                    foreach (RadioButton rdo in StatusGroup.Controls.OfType<RadioButton>())
                    {
                        if (rdo.Text == var_status.Text)
                        {
                            rdo.Checked = true;
                        }
                    }
                    foreach (RadioButton rdo in PriorityGroup.Controls.OfType<RadioButton>())
                    {
                        if (rdo.Text == var_priority.Text)
                        {
                            rdo.Checked = true;
                        }
                    }
                    StatusLabel.Text = "Status: - Filled";
                }
            }
            catch (Exception err)
            {
                StatusLabel.Text = "Status: -" + err.Message;
            }
        }

        private void DateLabel_Click(object sender, EventArgs e)
        {
            
        }

       

        private void date_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
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
             
                foreach (RadioButton rdo in StatusGroup.Controls.OfType<RadioButton>())
                {
                    if (rdo.Checked)
                    {
                        var_status.Text = rdo.Text;                        
                    }
                }
                foreach (RadioButton rdo in PriorityGroup.Controls.OfType<RadioButton>())
                {
                    if (rdo.Checked)
                    {
                        var_priority.Text = rdo.Text;
                    }
                }
                /*
                cmd.CommandText = "UPDATE order_status SET " +
                      "item_code = '" + item_code.Text + "'," +
                      "name = '" + name.Text + "'," +
                      "party_name = '" + party_name.Text + "'," +
                      "update_date = '" + date.Text + "'," +
                      "status = '" + var_status.Text + "'," +
                      "priority = '" + var_priority.Text + "'," +
                      "comments = '" + Comments.Text + "' " +
                      "where sr_no = " + sr_no.Text + ")";*/
                cmd.CommandText = "UPDATE order_status SET " +
              "item_code = @item_code," +
              "name = @name," +
              "party_name = @party_name," +
              "update_date = @update_date," +
              "status = @status," +
              "priority = @priority," +
              "comments = @comments" +
              " where sr_no = @sr_no";
                cmd.Parameters.AddWithValue("@item_code", item_code.Text);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@party_name", party_name.Text);
                cmd.Parameters.AddWithValue("@update_date", date.Text);
                cmd.Parameters.AddWithValue("@status",var_status.Text);
                cmd.Parameters.AddWithValue("@priority",var_priority.Text);
                cmd.Parameters.AddWithValue("@comments",Comments.Text);
                cmd.Parameters.AddWithValue("@sr_no",sr_no.Text);

                con.Open();
                rows = cmd.ExecuteNonQuery();
                StatusLabel.Text = "Status: - Rows Affected (" + rows.ToString()+")";
                updatedata();
            }
            catch (Exception err)
            {
                StatusLabel.Text = "Status: -" + err.Message;
            }
        }

        private void StatusGroup_Enter(object sender, EventArgs e)
        {

        }

        private void priority_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            updatedata();
            sr_no.Text = "";
            item_code.Text = "";
            name.Text = "";
            party_name.Text = "";            
            var_status.Text = "";
            var_priority.Text = "";
            foreach (RadioButton rdo in StatusGroup.Controls.OfType<RadioButton>())
            {
                rdo.Checked = false;
             
            }
            foreach (RadioButton rdo in PriorityGroup.Controls.OfType<RadioButton>())
            {
                rdo.Checked = false;
                Comments.Text = "";
            }

        }
        private void NewJob_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewJob frm2 = new NewJob();
            frm2.Show();
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
          
        }

        private void item_code_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
