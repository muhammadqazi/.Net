using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class progress : Form
    {
        public progress()
        {
            InitializeComponent();
        }

        private void progress_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 611)
            {
                timer1.Stop();
                login lg = new login();
                lg.Show();
                this.Hide();
            }
        }
    }
}
