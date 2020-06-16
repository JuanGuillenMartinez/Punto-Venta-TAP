namespace Prueba_Conexion_BD
{
    partial class Inventario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btnVerRegistros = new System.Windows.Forms.Button();
            this.dataGridView_productos = new System.Windows.Forms.DataGridView();
            this.label_id = new System.Windows.Forms.Label();
            this.label_descripcion = new System.Windows.Forms.Label();
            this.label_precio = new System.Windows.Forms.Label();
            this.tbox_id = new System.Windows.Forms.TextBox();
            this.tbox_descripcion = new System.Windows.Forms.TextBox();
            this.tbox_precio = new System.Windows.Forms.TextBox();
            this.label_existencias = new System.Windows.Forms.Label();
            this.tbox_existencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.btn_cargar_imagen = new System.Windows.Forms.Button();
            this.opendialog = new System.Windows.Forms.OpenFileDialog();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pb_producto = new System.Windows.Forms.PictureBox();
            this.btn_ver_venta = new System.Windows.Forms.Button();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(145, 18);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(301, 31);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Inventario de Productos";
            // 
            // btnVerRegistros
            // 
            this.btnVerRegistros.Location = new System.Drawing.Point(478, 472);
            this.btnVerRegistros.Name = "btnVerRegistros";
            this.btnVerRegistros.Size = new System.Drawing.Size(75, 23);
            this.btnVerRegistros.TabIndex = 10;
            this.btnVerRegistros.Text = "Actualizar";
            this.btnVerRegistros.UseVisualStyleBackColor = true;
            this.btnVerRegistros.Click += new System.EventHandler(this.btnVerRegistros_Click);
            // 
            // dataGridView_productos
            // 
            this.dataGridView_productos.AllowUserToAddRows = false;
            this.dataGridView_productos.AllowUserToDeleteRows = false;
            this.dataGridView_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.dataGridView_productos.Location = new System.Drawing.Point(22, 286);
            this.dataGridView_productos.Name = "dataGridView_productos";
            this.dataGridView_productos.ReadOnly = true;
            this.dataGridView_productos.Size = new System.Drawing.Size(531, 178);
            this.dataGridView_productos.TabIndex = 11;
            this.dataGridView_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_productos_CellClick);
            this.dataGridView_productos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(19, 84);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(80, 13);
            this.label_id.TabIndex = 12;
            this.label_id.Text = "ID del producto";
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.Location = new System.Drawing.Point(19, 114);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(63, 13);
            this.label_descripcion.TabIndex = 13;
            this.label_descripcion.Text = "Descripcion";
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Location = new System.Drawing.Point(19, 147);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(37, 13);
            this.label_precio.TabIndex = 14;
            this.label_precio.Text = "Precio";
            // 
            // tbox_id
            // 
            this.tbox_id.Location = new System.Drawing.Point(151, 77);
            this.tbox_id.Name = "tbox_id";
            this.tbox_id.Size = new System.Drawing.Size(176, 20);
            this.tbox_id.TabIndex = 15;
            // 
            // tbox_descripcion
            // 
            this.tbox_descripcion.Location = new System.Drawing.Point(151, 107);
            this.tbox_descripcion.Name = "tbox_descripcion";
            this.tbox_descripcion.Size = new System.Drawing.Size(176, 20);
            this.tbox_descripcion.TabIndex = 16;
            // 
            // tbox_precio
            // 
            this.tbox_precio.Location = new System.Drawing.Point(151, 140);
            this.tbox_precio.Name = "tbox_precio";
            this.tbox_precio.Size = new System.Drawing.Size(176, 20);
            this.tbox_precio.TabIndex = 17;
            // 
            // label_existencias
            // 
            this.label_existencias.AutoSize = true;
            this.label_existencias.Location = new System.Drawing.Point(19, 178);
            this.label_existencias.Name = "label_existencias";
            this.label_existencias.Size = new System.Drawing.Size(114, 13);
            this.label_existencias.TabIndex = 19;
            this.label_existencias.Text = "Numero de existencias";
            // 
            // tbox_existencia
            // 
            this.tbox_existencia.Location = new System.Drawing.Point(151, 171);
            this.tbox_existencia.Name = "tbox_existencia";
            this.tbox_existencia.Size = new System.Drawing.Size(176, 20);
            this.tbox_existencia.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Categoria";
            // 
            // cb_categoria
            // 
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(151, 200);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(176, 21);
            this.cb_categoria.TabIndex = 22;
            // 
            // btn_cargar_imagen
            // 
            this.btn_cargar_imagen.Location = new System.Drawing.Point(379, 230);
            this.btn_cargar_imagen.Name = "btn_cargar_imagen";
            this.btn_cargar_imagen.Size = new System.Drawing.Size(174, 23);
            this.btn_cargar_imagen.TabIndex = 23;
            this.btn_cargar_imagen.Text = "Cargar Imagen";
            this.btn_cargar_imagen.UseVisualStyleBackColor = true;
            this.btn_cargar_imagen.Click += new System.EventHandler(this.button1_Click);
            // 
            // opendialog
            // 
            this.opendialog.FileName = "fileDialog";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(22, 230);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(90, 23);
            this.btnRegistrar.TabIndex = 24;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(125, 230);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(96, 23);
            this.btnActualizar.TabIndex = 25;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(232, 230);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 23);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pb_producto
            // 
            this.pb_producto.ImageLocation = "";
            this.pb_producto.Location = new System.Drawing.Point(379, 73);
            this.pb_producto.Name = "pb_producto";
            this.pb_producto.Size = new System.Drawing.Size(174, 149);
            this.pb_producto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_producto.TabIndex = 18;
            this.pb_producto.TabStop = false;
            // 
            // btn_ver_venta
            // 
            this.btn_ver_venta.Location = new System.Drawing.Point(24, 472);
            this.btn_ver_venta.Name = "btn_ver_venta";
            this.btn_ver_venta.Size = new System.Drawing.Size(129, 23);
            this.btn_ver_venta.TabIndex = 27;
            this.btn_ver_venta.Text = "Ver productos en venta";
            this.btn_ver_venta.UseVisualStyleBackColor = true;
            this.btn_ver_venta.Click += new System.EventHandler(this.btn_ver_venta_Click);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Seleccionar";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Vender";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 504);
            this.Controls.Add(this.btn_ver_venta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btn_cargar_imagen);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_existencia);
            this.Controls.Add(this.label_existencias);
            this.Controls.Add(this.pb_producto);
            this.Controls.Add(this.tbox_precio);
            this.Controls.Add(this.tbox_descripcion);
            this.Controls.Add(this.tbox_id);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.label_descripcion);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.dataGridView_productos);
            this.Controls.Add(this.btnVerRegistros);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnVerRegistros;
        private System.Windows.Forms.DataGridView dataGridView_productos;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_descripcion;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.TextBox tbox_id;
        private System.Windows.Forms.TextBox tbox_descripcion;
        private System.Windows.Forms.TextBox tbox_precio;
        private System.Windows.Forms.PictureBox pb_producto;
        private System.Windows.Forms.Label label_existencias;
        private System.Windows.Forms.TextBox tbox_existencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.Button btn_cargar_imagen;
        private System.Windows.Forms.OpenFileDialog opendialog;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btn_ver_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

