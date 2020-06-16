namespace Prueba_Conexion_BD.Resources
{
    partial class FormVenta
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
            this.gridVentas = new System.Windows.Forms.DataGridView();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btnRegistrarVentas = new System.Windows.Forms.Button();
            this.grid_registro_ventas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_actualizar_ventas = new System.Windows.Forms.Button();
            this.btn_cancelar_venta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_registro_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // gridVentas
            // 
            this.gridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentas.Location = new System.Drawing.Point(19, 56);
            this.gridVentas.Name = "gridVentas";
            this.gridVentas.Size = new System.Drawing.Size(425, 241);
            this.gridVentas.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(188, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(99, 31);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Ventas";
            // 
            // btnRegistrarVentas
            // 
            this.btnRegistrarVentas.Location = new System.Drawing.Point(348, 303);
            this.btnRegistrarVentas.Name = "btnRegistrarVentas";
            this.btnRegistrarVentas.Size = new System.Drawing.Size(96, 23);
            this.btnRegistrarVentas.TabIndex = 2;
            this.btnRegistrarVentas.Text = "Registrar venta";
            this.btnRegistrarVentas.UseVisualStyleBackColor = true;
            this.btnRegistrarVentas.Click += new System.EventHandler(this.btnRegistrarVentas_Click);
            // 
            // grid_registro_ventas
            // 
            this.grid_registro_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_registro_ventas.Location = new System.Drawing.Point(552, 56);
            this.grid_registro_ventas.Name = "grid_registro_ventas";
            this.grid_registro_ventas.Size = new System.Drawing.Size(425, 241);
            this.grid_registro_ventas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(716, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ventas";
            // 
            // btn_actualizar_ventas
            // 
            this.btn_actualizar_ventas.Location = new System.Drawing.Point(902, 303);
            this.btn_actualizar_ventas.Name = "btn_actualizar_ventas";
            this.btn_actualizar_ventas.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar_ventas.TabIndex = 5;
            this.btn_actualizar_ventas.Text = "Actualizar";
            this.btn_actualizar_ventas.UseVisualStyleBackColor = true;
            this.btn_actualizar_ventas.Click += new System.EventHandler(this.btn_actualizar_ventas_Click);
            // 
            // btn_cancelar_venta
            // 
            this.btn_cancelar_venta.Location = new System.Drawing.Point(267, 303);
            this.btn_cancelar_venta.Name = "btn_cancelar_venta";
            this.btn_cancelar_venta.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_venta.TabIndex = 6;
            this.btn_cancelar_venta.Text = "Cancelar";
            this.btn_cancelar_venta.UseVisualStyleBackColor = true;
            this.btn_cancelar_venta.Click += new System.EventHandler(this.btn_cancelar_venta_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 345);
            this.Controls.Add(this.btn_cancelar_venta);
            this.Controls.Add(this.btn_actualizar_ventas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_registro_ventas);
            this.Controls.Add(this.btnRegistrarVentas);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.gridVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVenta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_registro_ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridVentas;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnRegistrarVentas;
        private System.Windows.Forms.DataGridView grid_registro_ventas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_actualizar_ventas;
        private System.Windows.Forms.Button btn_cancelar_venta;
    }
}