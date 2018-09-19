namespace cPanel
{
    partial class F_Estados
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
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_nombreTipo = new System.Windows.Forms.Label();
            this.lbl_idTipo = new System.Windows.Forms.Label();
            this.dgv_Estados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estados)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(62, 67);
            this.txt_Nombre.MaxLength = 8;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(189, 20);
            this.txt_Nombre.TabIndex = 35;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(36, 35);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(215, 20);
            this.txt_ID.TabIndex = 34;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(12, 13);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(35, 13);
            this.lbl_username.TabIndex = 33;
            this.lbl_username.Text = "label1";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(257, 33);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 32;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(338, 4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 31;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(257, 4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 30;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(257, 62);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 29;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(338, 33);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 28;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_nombreTipo
            // 
            this.lbl_nombreTipo.AutoSize = true;
            this.lbl_nombreTipo.Location = new System.Drawing.Point(12, 67);
            this.lbl_nombreTipo.Name = "lbl_nombreTipo";
            this.lbl_nombreTipo.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombreTipo.TabIndex = 27;
            this.lbl_nombreTipo.Text = "Nombre";
            // 
            // lbl_idTipo
            // 
            this.lbl_idTipo.AutoSize = true;
            this.lbl_idTipo.Location = new System.Drawing.Point(12, 43);
            this.lbl_idTipo.Name = "lbl_idTipo";
            this.lbl_idTipo.Size = new System.Drawing.Size(18, 13);
            this.lbl_idTipo.TabIndex = 26;
            this.lbl_idTipo.Text = "ID";
            // 
            // dgv_Estados
            // 
            this.dgv_Estados.AllowUserToOrderColumns = true;
            this.dgv_Estados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Estados.Location = new System.Drawing.Point(12, 110);
            this.dgv_Estados.Name = "dgv_Estados";
            this.dgv_Estados.Size = new System.Drawing.Size(426, 145);
            this.dgv_Estados.TabIndex = 25;
            this.dgv_Estados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Estados_CellClick);
            // 
            // F_Estados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 260);
            this.ControlBox = false;
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_nombreTipo);
            this.Controls.Add(this.lbl_idTipo);
            this.Controls.Add(this.dgv_Estados);
            this.Name = "F_Estados";
            this.Text = "Estados";
            this.Load += new System.EventHandler(this.F_Estados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_nombreTipo;
        private System.Windows.Forms.Label lbl_idTipo;
        private System.Windows.Forms.DataGridView dgv_Estados;
    }
}