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
    public partial class F_Login : Form
    {
        Usuarios usr = new Usuarios();

        public F_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            validarLogin(txt_Username.Text, txt_Password.Text);
            
        }

        void validarLogin(string username, string password)
        {
            try
            {
                using (FeelifyEntities conn = new FeelifyEntities())
                {
                    var resultado = conn.loginUsuario(username, password);
                    if (resultado.ToArray<loginUsuario_Result>().Count() == 1)
                    {
                        usr = (conn.Usuarios.Where(x => username == x.Username).FirstOrDefault());
                        loginScreen(true);
                    }
                    else
                        loginScreen(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void loginScreen(bool resultado)
        {
            if (resultado)
            {
                UsuarioActivo.data = usr;
                MessageBox.Show("Bienvenido " + UsuarioActivo.data.Nombre);
                this.Hide();
                var x = new F_HomeScreen();
                x.Closed += (s, args) => this.Close();
                x.Show();
            }
            else
            {
                txt_Password.Clear();
                txt_Username.Clear();
                MessageBox.Show("Error en las creedenciales","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
