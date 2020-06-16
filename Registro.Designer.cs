namespace Prueba_Conexion_BD
{
    partial class Registro
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
            this.tbox_rcontraseña = new System.Windows.Forms.TextBox();
            this.tbox_rusuario = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.PictureBox();
            this.btn_regresar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_registrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbox_rcontraseña
            // 
            this.tbox_rcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_rcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_rcontraseña.Location = new System.Drawing.Point(194, 264);
            this.tbox_rcontraseña.Name = "tbox_rcontraseña";
            this.tbox_rcontraseña.PasswordChar = '*';
            this.tbox_rcontraseña.Size = new System.Drawing.Size(219, 22);
            this.tbox_rcontraseña.TabIndex = 8;
            this.tbox_rcontraseña.UseSystemPasswordChar = true;
            // 
            // tbox_rusuario
            // 
            this.tbox_rusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_rusuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_rusuario.Location = new System.Drawing.Point(144, 179);
            this.tbox_rusuario.Name = "tbox_rusuario";
            this.tbox_rusuario.Size = new System.Drawing.Size(268, 22);
            this.tbox_rusuario.TabIndex = 7;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar.Location = new System.Drawing.Point(84, 351);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(299, 46);
            this.btn_registrar.TabIndex = 6;
            this.btn_registrar.TabStop = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.AutoSize = true;
            this.btn_regresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_regresar.Font = new System.Drawing.Font("qtquickcontrols", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.ForeColor = System.Drawing.Color.White;
            this.btn_regresar.Location = new System.Drawing.Point(178, 415);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(95, 20);
            this.btn_regresar.TabIndex = 9;
            this.btn_regresar.Text = "Iniciar sesion";
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prueba_Conexion_BD.Properties.Resources.InterfazRegistro;
            this.ClientSize = new System.Drawing.Size(451, 469);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.tbox_rcontraseña);
            this.Controls.Add(this.tbox_rusuario);
            this.Controls.Add(this.btn_registrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.btn_registrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_rcontraseña;
        private System.Windows.Forms.TextBox tbox_rusuario;
        private System.Windows.Forms.PictureBox btn_registrar;
        private System.Windows.Forms.Label btn_regresar;
    }
}