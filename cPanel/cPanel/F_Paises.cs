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
    public partial class F_Paises : Form
    {

        Paises Pais = new Paises();

        public F_Paises()
        {
            InitializeComponent();
        }

        void llenarDGV()
        {
            try
            {
                using(FeelifyEntities conn = new FeelifyEntities())
                {
                    dgv_Paises.DataSource = conn.Paises.ToList();
                }
            }
            catch
            {

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

        private void F_Paises_Load(object sender, EventArgs e)
        {
            lbl_username.Text = "Bienvenido: " + UsuarioActivo.data.Nombre;
            try
            {
                llenarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString(), "Mensaje de error :v");
            }
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
                        conn.insertarPais(txt_Nombre.Text);
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
            if (dgv_Paises.CurrentRow.Index != -1)
            {
                Pais.idPais = Int32.Parse(dgv_Paises.CurrentRow.Cells[0].Value.ToString());
                using (FeelifyEntities conn = new FeelifyEntities())
                {
                    Pais = conn.Paises.Where(x => x.idPais == Pais.idPais).FirstOrDefault();
                    txt_ID.Text = Pais.idPais.ToString();
                    txt_Nombre.Text = Pais.Nombre.ToString();
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
                        var entidad = conn.Entry(Pais);
                        if (entidad.State == System.Data.Entity.EntityState.Deleted)
                        {
                            conn.Paises.Attach(Pais);
                        }
                        if (Pais.idPais != -1)
                        {
                            Pais.idPais = Int32.Parse(txt_ID.Text);
                            conn.Entry(Pais).State = System.Data.Entity.EntityState.Deleted;
                            conn.SaveChanges();
                            MessageBox.Show("Tipo eliminado correctamente");
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

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FeelifyEntities conn = new FeelifyEntities())
                {
                    Pais.idPais = Int32.Parse(dgv_Paises.CurrentRow.Cells[0].Value.ToString());
                    Pais.Nombre = txt_Nombre.Text;
                    conn.Entry(Pais).State = System.Data.Entity.EntityState.Modified;
                    conn.SaveChanges();
                    MessageBox.Show("Actualizacion exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenarDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento la excepcion: " + ex.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
