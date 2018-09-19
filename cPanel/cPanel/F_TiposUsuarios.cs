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
        TiposUsuarios TipoUsuario = new TiposUsuarios();

        public F_TiposUsuarios()
        {
            InitializeComponent();
        }

        private void F_TiposUsuarios_Load(object sender, EventArgs e)
        {
            lbl_username.Text = "Bienvendio " + UsuarioActivo.data.Nombre;
            try
            {
                llenarDGV();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString(),"Mensaje de error :v");
            }
        }

        void llenarDGV()
        {
            try
            {
                using (FeelifyEntities conn = new FeelifyEntities())
                {
                    dgv_Tipos.DataSource = conn.TiposUsuarios.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.InnerException.ToString());
            }
        }

        bool revisarVacio()
        {
            if (txt_Nombre.Text == "")
                return true;
            else
                return false;
        }

        void vaciarInput()
        {
            txt_Nombre.Clear();
            txt_ID.Clear();
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
                        vaciarInput();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dgv_Tipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Tipos.CurrentRow.Index != -1)
            {
                TipoUsuario.idTipoUsuario = Int32.Parse(dgv_Tipos.CurrentRow.Cells[0].Value.ToString());
                using(FeelifyEntities conn = new FeelifyEntities())
                {
                    TipoUsuario = conn.TiposUsuarios.Where(x => x.idTipoUsuario == TipoUsuario.idTipoUsuario).FirstOrDefault();
                    txt_ID.Text = TipoUsuario.idTipoUsuario.ToString();
                    txt_Nombre.Text = TipoUsuario.Nombre.ToString();
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            vaciarInput();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FeelifyEntities conn = new FeelifyEntities())
                {
                    TipoUsuario.idTipoUsuario = Int32.Parse(dgv_Tipos.CurrentRow.Cells[0].Value.ToString());
                    TipoUsuario.Nombre = txt_Nombre.Text;
                    conn.Entry(TipoUsuario).State = System.Data.Entity.EntityState.Modified;
                    conn.SaveChanges();
                    MessageBox.Show("Actualizacion exitosa","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    llenarDGV();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se presento la excepcion: " + ex.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            llenarDGV();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var eliminarDato = MessageBox.Show("¿Desea eliminar el dato?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (eliminarDato == DialogResult.Yes)
                {
                    using (FeelifyEntities conn = new FeelifyEntities())
                    {
                        var entidad = conn.Entry(TipoUsuario);
                        if(entidad.State == System.Data.Entity.EntityState.Deleted)
                        {
                            conn.TiposUsuarios.Attach(TipoUsuario);
                        }
                        if(TipoUsuario.idTipoUsuario != -1)
                        {
                            TipoUsuario.idTipoUsuario = Int32.Parse(txt_ID.Text);
                            conn.Entry(TipoUsuario).State = System.Data.Entity.EntityState.Deleted;
                            conn.SaveChanges();
                            MessageBox.Show("Tipo eliminado correctamente");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente error " + ex.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            llenarDGV();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            var x = new F_HomeScreen();
            x.Closed += (s, args) => this.Close();
            x.Show();
        }
    }
}
