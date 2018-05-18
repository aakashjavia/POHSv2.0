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
    public partial class SplashStartup : Form
    {
        public SplashStartup()
        {
            InitializeComponent();
        }

        Timer tmr;
        MetroApp metro = new MetroApp();
        
        private void SplashStartup_Shown(object sender, EventArgs e)
        {
            
            metro.Show();
            metro.WindowState = FormWindowState.Minimized;
         //   metro.Visible = false;
            tmr = new Timer();
            tmr.Interval = 3000;
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        void tmr_Tick(object sender, EventArgs e)

        {
            tmr.Stop();
            metro.WindowState = FormWindowState.Maximized;
         //   metro.Visible = true;
            this.Hide();
        }

        private void SplashStartup_Load(object sender, EventArgs e)
        {

        }
    }
}
