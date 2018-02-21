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
           
           

            // Sizes the tabs so that each row fills the entire width of tabControl1.
            this.metroTabControl1.SizeMode = TabSizeMode.Normal;

            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Padding = new Point(15, 5);

            metroTabControl1.TabPages[0].Controls.Add(new NewJob());
            metroTabControl1.TabPages[1].Controls.Add(new JobCard());
            metroTabControl1.TabPages[2].Controls.Add(new OrderStatus());
            metroTabControl1.TabPages[3].Controls.Add(new Inventory());
            this.metroTabControl1.Location = new Point(1, 1);
            this.metroTabControl1.Size = new Size(740, 1000);

        //    this.Size = new Size(300, 300);
            this.Controls.Add(metroTabControl1);
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }
    }
    }

    

