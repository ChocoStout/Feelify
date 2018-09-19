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
            timer_Home.Start();
            if((UsuarioActivo.data.idTipoUsuario) != 1)
            {
                tsmi_Admin.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_Home.Interval = 1000;
            this.lbl_Hora.Text = DateTime.Now.ToString();
        }

        private void tsmi_TipoUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            var x = new F_TiposUsuarios();
            x.Closed += (s, args) => this.Close();
            x.Show();
        }

        private void tsmi_Paises_Click(object sender, EventArgs e)
        {
            this.Hide();
            var x = new F_Paises();
            x.Closed += (s, args) => this.Close();
            x.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var x = new F_Estados();
            x.Closed += (s, args) => this.Close();
            x.Show();
        }

        private void tsmi_Usuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            var x = new F_Usuarios();
            x.Closed += (s, args) => this.Close();
            x.Show();
        }
    }
}
