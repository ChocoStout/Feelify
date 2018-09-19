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
    public partial class F_Estados : Form
    {
        Estados Estado = new Estados();

        public F_Estados()
        {
            InitializeComponent();
        }

        private void F_Estados_Load(object sender, EventArgs e)
        {
            lbl_username.Text = "Bienvendio " + UsuarioActivo.data.Nombre;
            try
            {
                llenarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString(), "Mensaje de error :v");
            }
        }

        void llenarDGV()
        {
            try
            {
                using(FeelifyEntities conn = new FeelifyEntities())
                {
                    dgv_Estados.DataSource = conn.Estados.ToList();
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
                        conn.insertarEstados(txt_Nombre.Text);
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

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FeelifyEntities conn = new FeelifyEntities())
                {
                    Estado.idEstado = Int32.Parse(dgv_Estados.CurrentRow.Cells[0].Value.ToString());
                    Estado.Nombre = txt_Nombre.Text;
                    conn.Entry(Estado).State = System.Data.Entity.EntityState.Modified;
                    conn.SaveChanges();
                    MessageBox.Show("Actualizacion exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenarDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento la excepcion: " + ex.InnerException.ToString(), "Error");
            }
            llenarDGV();
        }

        private void dgv_Estados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Estados.CurrentRow.Index != -1)
            {
               Estado.idEstado = Int32.Parse(dgv_Estados.CurrentRow.Cells[0].Value.ToString());
                using (FeelifyEntities conn = new FeelifyEntities())
                {
                    Estado = conn.Estados.Where(x => x.idEstado == Estado.idEstado).FirstOrDefault();
                    txt_ID.Text = Estado.idEstado.ToString();
                    txt_Nombre.Text = Estado.Nombre.ToString();
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            vaciarInput();
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
                        var entidad = conn.Entry(Estado);
                        if (entidad.State == System.Data.Entity.EntityState.Deleted)
                        {
                            conn.Estados.Attach(Estado);
                        }
                        if (Estado.idEstado != -1)
                        {
                            Estado.idEstado = Int32.Parse(txt_ID.Text);
                            conn.Entry(Estado).State = System.Data.Entity.EntityState.Deleted;
                            conn.SaveChanges();
                            MessageBox.Show("Estado eliminado correctamente");
                        }
                    }
                }
            }
            catch (Exception ex)
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
