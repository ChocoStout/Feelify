namespace cPanel
{
    partial class F_Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.lbl_useractual = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_paterno = new System.Windows.Forms.TextBox();
            this.lbl_paterno = new System.Windows.Forms.Label();
            this.txt_materno = new System.Windows.Forms.TextBox();
            this.lbl_materno = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.cb_pais = new System.Windows.Forms.ComboBox();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.pb_imagen = new System.Windows.Forms.PictureBox();
            this.fbd_Imagen = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscarImagen = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(12, 288);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.Size = new System.Drawing.Size(619, 150);
            this.dgv_usuarios.TabIndex = 0;
            // 
            // lbl_useractual
            // 
            this.lbl_useractual.AutoSize = true;
            this.lbl_useractual.Location = new System.Drawing.Point(9, 9);
            this.lbl_useractual.Name = "lbl_useractual";
            this.lbl_useractual.Size = new System.Drawing.Size(35, 13);
            this.lbl_useractual.TabIndex = 1;
            this.lbl_useractual.Text = "label1";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(9, 34);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(69, 31);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(137, 20);
            this.txt_id.TabIndex = 3;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(311, 31);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(137, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(249, 34);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_paterno
            // 
            this.txt_paterno.Location = new System.Drawing.Point(69, 57);
            this.txt_paterno.Name = "txt_paterno";
            this.txt_paterno.Size = new System.Drawing.Size(137, 20);
            this.txt_paterno.TabIndex = 7;
            // 
            // lbl_paterno
            // 
            this.lbl_paterno.AutoSize = true;
            this.lbl_paterno.Location = new System.Drawing.Point(9, 60);
            this.lbl_paterno.Name = "lbl_paterno";
            this.lbl_paterno.Size = new System.Drawing.Size(54, 13);
            this.lbl_paterno.TabIndex = 6;
            this.lbl_paterno.Text = "A Paterno";
            // 
            // txt_materno
            // 
            this.txt_materno.Location = new System.Drawing.Point(311, 57);
            this.txt_materno.Name = "txt_materno";
            this.txt_materno.Size = new System.Drawing.Size(137, 20);
            this.txt_materno.TabIndex = 9;
            // 
            // lbl_materno
            // 
            this.lbl_materno.AutoSize = true;
            this.lbl_materno.Location = new System.Drawing.Point(249, 60);
            this.lbl_materno.Name = "lbl_materno";
            this.lbl_materno.Size = new System.Drawing.Size(56, 13);
            this.lbl_materno.TabIndex = 8;
            this.lbl_materno.Text = "A Materno";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(69, 82);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(137, 20);
            this.txt_correo.TabIndex = 11;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(9, 86);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(38, 13);
            this.lbl_correo.TabIndex = 10;
            this.lbl_correo.Text = "Correo";
            // 
            // txt_password
            // 
            this.txt_password.Enabled = false;
            this.txt_password.Location = new System.Drawing.Point(316, 86);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(137, 20);
            this.txt_password.TabIndex = 13;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(249, 89);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(61, 13);
            this.lbl_password.TabIndex = 12;
            this.lbl_password.Text = "Contraseña";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(69, 109);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(137, 20);
            this.txt_username.TabIndex = 17;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(9, 112);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 16;
            this.lbl_username.Text = "Username";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Enabled = false;
            this.txt_fecha.Location = new System.Drawing.Point(331, 112);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(137, 20);
            this.txt_fecha.TabIndex = 19;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(249, 115);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(76, 13);
            this.lbl_fecha.TabIndex = 18;
            this.lbl_fecha.Text = "FechaRegistro";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(449, 144);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado.TabIndex = 20;
            this.lbl_estado.Text = "Estado";
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Location = new System.Drawing.Point(494, 141);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(137, 21);
            this.cb_estado.TabIndex = 21;
            // 
            // cb_pais
            // 
            this.cb_pais.FormattingEnabled = true;
            this.cb_pais.Location = new System.Drawing.Point(69, 135);
            this.cb_pais.Name = "cb_pais";
            this.cb_pais.Size = new System.Drawing.Size(137, 21);
            this.cb_pais.TabIndex = 23;
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Location = new System.Drawing.Point(9, 141);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(27, 13);
            this.lbl_pais.TabIndex = 22;
            this.lbl_pais.Text = "Pais";
            // 
            // cb_tipo
            // 
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Location = new System.Drawing.Point(290, 138);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(137, 21);
            this.cb_tipo.TabIndex = 25;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(249, 144);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(28, 13);
            this.lbl_tipo.TabIndex = 24;
            this.lbl_tipo.Text = "Tipo";
            // 
            // pb_imagen
            // 
            this.pb_imagen.Location = new System.Drawing.Point(452, 171);
            this.pb_imagen.Name = "pb_imagen";
            this.pb_imagen.Size = new System.Drawing.Size(175, 111);
            this.pb_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imagen.TabIndex = 26;
            this.pb_imagen.TabStop = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(12, 184);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 27;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(12, 213);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 28;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(12, 242);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 29;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_buscarImagen
            // 
            this.btn_buscarImagen.Location = new System.Drawing.Point(344, 213);
            this.btn_buscarImagen.Name = "btn_buscarImagen";
            this.btn_buscarImagen.Size = new System.Drawing.Size(102, 23);
            this.btn_buscarImagen.TabIndex = 30;
            this.btn_buscarImagen.Text = "Cambiar imagen";
            this.btn_buscarImagen.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(93, 197);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 31;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(93, 226);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 32;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // F_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_buscarImagen);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.pb_imagen);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.cb_pais);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.txt_materno);
            this.Controls.Add(this.lbl_materno);
            this.Controls.Add(this.txt_paterno);
            this.Controls.Add(this.lbl_paterno);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_useractual);
            this.Controls.Add(this.dgv_usuarios);
            this.Name = "F_Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.F_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Label lbl_useractual;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_paterno;
        private System.Windows.Forms.Label lbl_paterno;
        private System.Windows.Forms.TextBox txt_materno;
        private System.Windows.Forms.Label lbl_materno;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.ComboBox cb_pais;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.PictureBox pb_imagen;
        private System.Windows.Forms.FolderBrowserDialog fbd_Imagen;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscarImagen;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_cancelar;
    }
}