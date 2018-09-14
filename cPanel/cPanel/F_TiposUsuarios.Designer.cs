namespace cPanel
{
    partial class F_TiposUsuarios
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
            this.dgv_Tipos = new System.Windows.Forms.DataGridView();
            this.lbl_idTipo = new System.Windows.Forms.Label();
            this.lbl_nombreTipo = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tipos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Tipos
            // 
            this.dgv_Tipos.AllowUserToOrderColumns = true;
            this.dgv_Tipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tipos.Location = new System.Drawing.Point(12, 118);
            this.dgv_Tipos.Name = "dgv_Tipos";
            this.dgv_Tipos.Size = new System.Drawing.Size(253, 161);
            this.dgv_Tipos.TabIndex = 0;
            // 
            // lbl_idTipo
            // 
            this.lbl_idTipo.AutoSize = true;
            this.lbl_idTipo.Location = new System.Drawing.Point(12, 12);
            this.lbl_idTipo.Name = "lbl_idTipo";
            this.lbl_idTipo.Size = new System.Drawing.Size(18, 13);
            this.lbl_idTipo.TabIndex = 1;
            this.lbl_idTipo.Text = "ID";
            // 
            // lbl_nombreTipo
            // 
            this.lbl_nombreTipo.AutoSize = true;
            this.lbl_nombreTipo.Location = new System.Drawing.Point(12, 37);
            this.lbl_nombreTipo.Name = "lbl_nombreTipo";
            this.lbl_nombreTipo.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombreTipo.TabIndex = 2;
            this.lbl_nombreTipo.Text = "Nombre";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(12, 60);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 3;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(93, 60);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 4;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(176, 60);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 5;
            this.btn_Eliminar.Text = "Salir";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(46, 89);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(127, 89);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 7;
            this.btn_Salir.Text = "Volver";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(62, 34);
            this.txt_Nombre.MaxLength = 11;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(189, 20);
            this.txt_Nombre.TabIndex = 8;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(36, 12);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(215, 20);
            this.txt_ID.TabIndex = 9;
            // 
            // F_TiposUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 291);
            this.ControlBox = false;
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_nombreTipo);
            this.Controls.Add(this.lbl_idTipo);
            this.Controls.Add(this.dgv_Tipos);
            this.Name = "F_TiposUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de usuarios";
            this.Load += new System.EventHandler(this.F_TiposUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Tipos;
        private System.Windows.Forms.Label lbl_idTipo;
        private System.Windows.Forms.Label lbl_nombreTipo;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_ID;
    }
}