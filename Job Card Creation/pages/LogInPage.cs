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
using System.Security.Cryptography;

namespace Job_Card_Creation.pages
{
    public partial class LogInPage : Form
    {
        int sr = 0;
        public LogInPage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string hashing(string txt)
        {            
            byte[] salt;            
            salt = new byte[16];           
            var pbkdf2 = new Rfc2898DeriveBytes(txt, salt, 1000);

            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string hashed_password = Convert.ToBase64String(hashBytes);
            
            return hashed_password;
        }
        public void newuser(string username, string password)
        {
            string hashed_password = "";
            hashed_password = hashing(password);
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\Database1.mdf; Integrated Security = True");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO userrecords values (" + sr.ToString() + ",'"+hashed_password+"','" + username + "')";
            con.Open();
            int r_affected = cmd.ExecuteNonQuery();
            MessageBox.Show("User Updated:-"+r_affected);
            con.Close();
        }
        public void Fill_sr_no()
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                
                SqlConnection con;
                con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from userrecords order by sr_no desc";
                cmd.Connection = con;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    sr = reader.GetInt32(0) + 1;                    
                }
              
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: - " + err.Message);
            }

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\Database1.mdf; Integrated Security = True");
                string checkhash = hashing(txtPwd.Text);
              //  MessageBox.Show("Hash recieved is:-"+checkhash);
                SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from userrecords where username='" + txtUserId.Text + "' and password='" + checkhash + "'", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    MetroApp ma = new MetroApp();
                    ma.Show();
                }
                else
                {
                    MessageBox.Show("Please Enter Valid UserId and Password");
                }
            }
                  catch (Exception err)
            {
                MessageBox.Show("Error: - " + err.Message);
            }
        }

        private void LogInPage_Load(object sender, EventArgs e)
        {
           //newuser("admin", "admin");
        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
