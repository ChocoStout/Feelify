namespace cPanel
{
    partial class F_HomeScreen
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.timer_Home = new System.Windows.Forms.Timer(this.components);
            this.ms_Home = new System.Windows.Forms.MenuStrip();
            this.tsmi_Canciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Playlists = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_TipoUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.paisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tuCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Location = new System.Drawing.Point(103, 50);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(62, 13);
            this.lbl_Hora.TabIndex = 0;
            this.lbl_Hora.Text = "Hora actual";
            // 
            // timer_Home
            // 
            this.timer_Home.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ms_Home
            // 
            this.ms_Home.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.ms_Home.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Canciones,
            this.tsmi_Playlists,
            this.tsmi_Admin,
            this.tuCuentaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.ms_Home.Location = new System.Drawing.Point(0, 0);
            this.ms_Home.Name = "ms_Home";
            this.ms_Home.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ms_Home.Size = new System.Drawing.Size(315, 24);
            this.ms_Home.TabIndex = 1;
            this.ms_Home.Text = "Menu";
            // 
            // tsmi_Canciones
            // 
            this.tsmi_Canciones.Name = "tsmi_Canciones";
            this.tsmi_Canciones.Size = new System.Drawing.Size(57, 20);
            this.tsmi_Canciones.Text = "Musica";
            // 
            // tsmi_Playlists
            // 
            this.tsmi_Playlists.Name = "tsmi_Playlists";
            this.tsmi_Playlists.Size = new System.Drawing.Size(61, 20);
            this.tsmi_Playlists.Text = "Playlists";
            // 
            // tsmi_Admin
            // 
            this.tsmi_Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_TipoUsuarios,
            this.paisesToolStripMenuItem,
            this.estadosToolStripMenuItem,
            this.usuariosToolStripMenuItem1});
            this.tsmi_Admin.Name = "tsmi_Admin";
            this.tsmi_Admin.Size = new System.Drawing.Size(55, 20);
            this.tsmi_Admin.Text = "Admin";
            // 
            // tsmi_TipoUsuarios
            // 
            this.tsmi_TipoUsuarios.Name = "tsmi_TipoUsuarios";
            this.tsmi_TipoUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsmi_TipoUsuarios.Text = "Tipo de usuarios";
            this.tsmi_TipoUsuarios.Click += new System.EventHandler(this.tsmi_TipoUsuarios_Click);
            // 
            // paisesToolStripMenuItem
            // 
            this.paisesToolStripMenuItem.Name = "paisesToolStripMenuItem";
            this.paisesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paisesToolStripMenuItem.Text = "Paises";
            // 
            // estadosToolStripMenuItem
            // 
            this.estadosToolStripMenuItem.Name = "estadosToolStripMenuItem";
            this.estadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estadosToolStripMenuItem.Text = "Estados";
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            // 
            // tuCuentaToolStripMenuItem
            // 
            this.tuCuentaToolStripMenuItem.Name = "tuCuentaToolStripMenuItem";
            this.tuCuentaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.tuCuentaToolStripMenuItem.Text = "Tu cuenta";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // F_HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 84);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.ms_Home);
            this.MainMenuStrip = this.ms_Home;
            this.Name = "F_HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feelify";
            this.Load += new System.EventHandler(this.F_HomeScreen_Load);
            this.ms_Home.ResumeLayout(false);
            this.ms_Home.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Timer timer_Home;
        private System.Windows.Forms.MenuStrip ms_Home;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Canciones;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Playlists;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Admin;
        private System.Windows.Forms.ToolStripMenuItem tsmi_TipoUsuarios;
        private System.Windows.Forms.ToolStripMenuItem paisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tuCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}