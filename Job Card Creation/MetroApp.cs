using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Job_Card_Creation
{
    public partial class MetroApp : Form
    {
        public MetroApp()
        {
            InitializeComponent();
        }

        private void metroTest_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            // Sizes the tabs so that each row fills the entire width of tabControl1.
            this.metroTabControl1.SizeMode = TabSizeMode.Normal;
            Color backcolor = new Color();
            backcolor = Color.LightYellow;
            this.BackColor = backcolor;
            NewJob uc1 = new NewJob();
            JobCard uc2 = new JobCard();
            OrderStatus uc3 = new OrderStatus();
            Inventory uc4 = new Inventory();

           


            metroTabControl1.UseCustomBackColor = true;
       
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Padding = new Point(15, 5);
      
            metroTabControl1.TabPages[0].Controls.Add(uc1);
            metroTabControl1.TabPages[1].Controls.Add(uc2);
            metroTabControl1.TabPages[2].Controls.Add(uc3);
            metroTabControl1.TabPages[3].Controls.Add(uc4);

          //  this.metroTabControl1.Location = new Point(1, 1);
            this.metroTabControl1.Size = new Size(740, 1080);

            //Coloring Block
            metroTabControl1.SelectedTab.BackColor =backcolor;
            uc1.BackColor = backcolor;
            uc2.BackColor = backcolor;
            uc3.BackColor = backcolor;
            uc4.BackColor = backcolor;
            metroTabControl1.TabPages[0].BackColor =backcolor;
            metroTabControl1.TabPages[1].BackColor =backcolor;
            metroTabControl1.TabPages[2].BackColor =backcolor;
            metroTabControl1.TabPages[3].BackColor =backcolor;
           
            //    this.Size = new Size(300, 300);
            this.Controls.Add(metroTabControl1);
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    }