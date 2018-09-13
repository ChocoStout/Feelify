using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cPanel
{
    public partial class F_HomeScreen : Form
    {
        public F_HomeScreen()
        {
            InitializeComponent();
        }

        private void F_HomeScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            this.label1.Text = DateTime.Now.ToString();
        }
    }
}
