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
    public partial class JobCard : Form
    {
        private Button button2 = new Button();
  

        public JobCard()
        {
            InitializeComponent();
          
        }

        //for converting to image
        
        private System.IO.Stream streamToPrint;
        string streamType;
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]

        private static extern bool BitBlt
        (
            IntPtr hdcDest, // handle to destination DC
            int nXDest, // x-coord of destination upper-left corner
            int nYDest, // y-coord of destination upper-left corner
            int nWidth, // width of destination rectangle
            int nHeight, // height of destination rectangle
            IntPtr hdcSrc, // handle to source DC
            int nXSrc, // x-coordinate of source upper-left corner
            int nYSrc, // y-coordinate of source upper-left corner
            System.Int32 dwRop // raster operation code
        );


        
        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Image image = System.Drawing.Image.FromStream(this.streamToPrint);
            int x = e.MarginBounds.X;
            int y = e.MarginBounds.Y;
            int width = image.Width;
            int height = image.Height;
            if ((width / e.MarginBounds.Width) > (height / e.MarginBounds.Height))
            {
                width = e.MarginBounds.Width;
                height = image.Height * e.MarginBounds.Width / image.Width;
            }
            else
            {
                height = e.MarginBounds.Height;
                width = image.Width * e.MarginBounds.Height / image.Height;
            }
            System.Drawing.Rectangle destRect = new System.Drawing.Rectangle(x, y, width, height);
            e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel);
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
                cmd.CommandText = "select * from job_card order by sr_no desc";
                cmd.Connection = con;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    sr = reader.GetInt32(0) + 1;
                    sr_no.Text = sr.ToString();
                    StatusLabel.Text = "STATUS(Form1_Load):-Number Filled";
                }
                con.Close();
            }
                
            
            catch (Exception err)
            {
                StatusLabel.Text = "STATUS(Form1_Load):-" + err.Message;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PrinterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_3(object sender, EventArgs e)
        {

        }

        private void PartyLabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void InputDate_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int r_affected;
              
                SqlCommand cmd = new SqlCommand();
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from job_card order by sr_no desc";
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
                StatusLabel.Text = "STATUS(button1_Click):- Data Accepted (" +r_affected.ToString()+ ") ";
            }
            catch (Exception err)
            {
                StatusLabel.Text = "STATUS(button1_Click):-" + err.Message;
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
                cmd.CommandText = "select * from job_card order by sr_no desc";
                cmd.Connection = con;
               
                //For AutoComplete
                item_code.AutoCompleteMode = AutoCompleteMode.Suggest;
                item_code.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                
                // Retrieve all rows
                cmd.CommandText = "SELECT * FROM job_info";
                cmd.Connection = con;
                con.Open();
                using (var read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        collection.Add(read["item_code"].ToString());
                    }
                }

                item_code.AutoCompleteCustomSource = collection;
                cmd.CommandText = "select * from job_info where item_code = '" + this.item_code.Text + "'";



               
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
                    StatusLabel.Text = "STATUS(JobCode_TextChanged):- Data Filled";
                }
                con.Close();
            }
            catch (Exception err)
            {
                StatusLabel.Text = "STATUS(JobCode_TextChanged):-" + err.Message;
            }
        }
      
            
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "";
            dateTimePicker1.Visible = false;
            SubmitButton.Visible = false;
            printButton.Visible = false;
            try { 
                        Graphics g1 = this.CreateGraphics();
                        Image MyImage = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, g1);
                        Graphics g2 = Graphics.FromImage(MyImage);
                        IntPtr dc1 = g1.GetHdc();
                        IntPtr dc2 = g2.GetHdc();
                        BitBlt(dc2, 0, 0, ClientRectangle.Width, ClientRectangle.Height, dc1, 0, 0, 13369376);
                        //backed up above line: - BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
                        g1.ReleaseHdc(dc1);
                        g2.ReleaseHdc(dc2);
                saveFileDialog1.FileName = item_code.Text+"-"+date.Text;
                saveFileDialog1.Filter = "Image Files| *.jpg;";

                saveFileDialog1.ShowDialog();


                        MyImage.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                StatusLabel.Text = "File Stored at..."+ saveFileDialog1.FileName.ToString();

                SubmitButton.Visible = true;
                printButton.Visible = true;

            }

            catch (Exception err)
            {
                StatusLabel.Text = "STATUS(button2_Click):-" + err.Message;
            }
        

          
        }
        public void StartPrint(Stream streamToPrint, string streamType)
        {
            this.printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            this.streamToPrint = streamToPrint;
            this.streamType = streamType;
            System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = printDocument1;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
                //docToPrint.Print();
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void date_onclick(object sender, EventArgs e)
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
            DateTime dt = DateTime.ParseExact(date.ToString(), "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);

            string s = dt.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
            date.Text = s;
        }

        private void date_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void JobSheetNo_Click(object sender, EventArgs e)
        {

        }
    }
}
