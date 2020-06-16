namespace Prueba_Conexion_BD
{
    partial class Login
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
            this.btn_iniciar_sesion = new System.Windows.Forms.PictureBox();
            this.tbox_contraseña = new System.Windows.Forms.TextBox();
            this.tbox_usuario = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_iniciar_sesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_registrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_iniciar_sesion
            // 
            this.btn_iniciar_sesion.BackColor = System.Drawing.Color.Transparent;
            this.btn_iniciar_sesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iniciar_sesion.Location = new System.Drawing.Point(92, 341);
            this.btn_iniciar_sesion.Name = "btn_iniciar_sesion";
            this.btn_iniciar_sesion.Size = new System.Drawing.Size(299, 46);
            this.btn_iniciar_sesion.TabIndex = 3;
            this.btn_iniciar_sesion.TabStop = false;
            this.btn_iniciar_sesion.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbox_contraseña
            // 
            this.tbox_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_contraseña.Location = new System.Drawing.Point(123, 260);
            this.tbox_contraseña.Name = "tbox_contraseña";
            this.tbox_contraseña.PasswordChar = '*';
            this.tbox_contraseña.Size = new System.Drawing.Size(268, 22);
            this.tbox_contraseña.TabIndex = 5;
            this.tbox_contraseña.UseSystemPasswordChar = true;
            // 
            // tbox_usuario
            // 
            this.tbox_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_usuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_usuario.Location = new System.Drawing.Point(123, 178);
            this.tbox_usuario.Name = "tbox_usuario";
            this.tbox_usuario.Size = new System.Drawing.Size(268, 22);
            this.tbox_usuario.TabIndex = 4;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar.Location = new System.Drawing.Point(321, 29);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(141, 46);
            this.btn_registrar.TabIndex = 6;
            this.btn_registrar.TabStop = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prueba_Conexion_BD.Properties.Resources.InterfazUsuario;
            this.ClientSize = new System.Drawing.Size(474, 470);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.tbox_contraseña);
            this.Controls.Add(this.tbox_usuario);
            this.Controls.Add(this.btn_iniciar_sesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.btn_iniciar_sesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_registrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btn_iniciar_sesion;
        private System.Windows.Forms.TextBox tbox_contraseña;
        private System.Windows.Forms.TextBox tbox_usuario;
        private System.Windows.Forms.PictureBox btn_registrar;
    }
}