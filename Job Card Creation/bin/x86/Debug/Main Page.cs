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
            
            JobCard frm1 = new JobCard();
            frm1.StartPosition = FormStartPosition.Manual;
            frm1.Show();
        }

        private void toNewJobForm_Click(object sender, EventArgs e)
        {
            
            NewJob frm2 = new NewJob();
            frm2.StartPosition = FormStartPosition.Manual;
            frm2.Show();
        }

        private void toInventory_Click(object sender, EventArgs e)
        {
            
            Inventory frm3 = new Inventory();
            frm3.StartPosition = FormStartPosition.Manual;
            frm3.Show();
        }

        private void toOrderStatus_Click(object sender, EventArgs e)
        {
           
            OrderStatus frm4 = new OrderStatus();
            frm4.StartPosition = FormStartPosition.Manual;
            frm4.Show();
        }
        private void title1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
