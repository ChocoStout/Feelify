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
    public partial class F_Usuarios : Form
    {
        Usuarios usuario = new Usuarios();

        public F_Usuarios()
        {
            InitializeComponent();
        }

        private void F_Usuarios_Load(object sender, EventArgs e)
        {
            lbl_useractual.Text = UsuarioActivo.data.Nombre;
            try
            {
                using (FeelifyEntities conn = new FeelifyEntities())
                {
                    llenarDGV();
                    txt_fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    cb_pais.DataSource = conn.Paises.ToList();
                    cb_estado.DataSource = conn.Estados.ToList();
                    cb_tipo.DataSource = conn.TiposUsuarios.ToList();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            void llenarDGV()
            {
                using (FeelifyEntities conn = new FeelifyEntities())
                {
                    dgv_usuarios.DataSource = conn.Usuarios.ToList();
                    dgv_usuarios.Columns.Remove(dgv_usuarios.Columns[11]);
                    for (int i = 0; i < conn.Usuarios.ToList().Count(); i++)
                    {
                        dgv_usuarios.Rows[i].Cells[5].Value = convertirClave(dgv_usuarios.Rows[i].Cells[5].Value.ToString());
                    }
                }
            }

            string convertirClave(string x)
            {
                List<Byte> listaBits = new List<Byte>();
                for (int i = 0; i < x.Length; i += 8)
                {
                    listaBits.Add(Convert.ToByte(x.Substring(i, 8), 2));
                }
                return Encoding.ASCII.GetString(listaBits.ToArray());
            }
        }
    }
}
