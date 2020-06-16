namespace Prueba_Conexion_BD
{
    partial class Cargando
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
            this.pb_cargando = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cargando)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_cargando
            // 
            this.pb_cargando.Image = global::Prueba_Conexion_BD.Properties.Resources.Loading;
            this.pb_cargando.Location = new System.Drawing.Point(19, 10);
            this.pb_cargando.Name = "pb_cargando";
            this.pb_cargando.Size = new System.Drawing.Size(352, 231);
            this.pb_cargando.TabIndex = 0;
            this.pb_cargando.TabStop = false;
            // 
            // Cargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 245);
            this.Controls.Add(this.pb_cargando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cargando";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargando";
            this.Load += new System.EventHandler(this.Cargando_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_cargando)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_cargando;
    }
}