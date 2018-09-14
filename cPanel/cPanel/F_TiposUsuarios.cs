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
    public partial class F_TiposUsuarios : Form
    {
        public F_TiposUsuarios()
        {
            InitializeComponent();
        }

        private void F_TiposUsuarios_Load(object sender, EventArgs e)
        {
            llenarDGV();
        }

        void llenarDGV()
        {
            using(FeelifyEntities conn = new FeelifyEntities())
            {
                dgv_Tipos.DataSource = conn.TiposUsuarios.ToList();
            }
        }

        bool revisarVacio()
        {
            if (txt_Nombre.Text == "")
                return true;
            else
                return false;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (revisarVacio())
            {
                MessageBox.Show("No se ha insertado un valor para el nombre");
            }
            else
            {
                try
                {
                    using (FeelifyEntities conn = new FeelifyEntities())
                    {
                        conn.insertarTipoUsuario(txt_Nombre.Text);
                        llenarDGV();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
