using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Card_Creation
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
        }

        private void toJobCardForm_Click(object sender, EventArgs e)
        {            
          
        }

        private void toNewJobForm_Click(object sender, EventArgs e)
        {
          
        }

        private void toInventory_Click(object sender, EventArgs e)
        {
           
        }

        private void toOrderStatus_Click(object sender, EventArgs e)
        {
           
        }
        private void title1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetroApp form4 = new MetroApp();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllJobInfo form1 = new AllJobInfo();
            form1.Show();
        }
    }
}
