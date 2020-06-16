using Prueba_Conexion_BD.Resources;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Prueba_Conexion_BD
{
    public partial class Inventario : Form
    {

        Boolean estado = true;

        public Inventario()
        {
            InitializeComponent();
            Thread hiloImagenes = new Thread(new ThreadStart(mostrarImagenesDefault));
            hiloImagenes.Start();
        }

        private void btnVerRegistros_Click(object sender, EventArgs e)
        {
            mostrarTablaProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            importarImagen();
            estado = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string descripcion = tbox_descripcion.Text;
            string precio = tbox_precio.Text;
            string existencias = tbox_existencia.Text;
            string categoria = cb_categoria.SelectedItem.ToString();
            byte[] imagen = pictureBoxToImagen(pb_producto);
            ConexionBD.RegistrarProducto(descripcion, precio, existencias, categoria, imagen);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = tbox_id.Text;
            string descripcion = tbox_descripcion.Text;
            string precio = tbox_precio.Text;
            string existencias = tbox_existencia.Text;
            string categoria = cb_categoria.SelectedItem.ToString();
            byte[] imagen = pictureBoxToImagen(pb_producto);
            ConexionBD.ActualizarProducto(id, descripcion, precio, existencias, categoria, imagen);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = tbox_id.Text;
            ConexionBD.EliminarProducto(id);
        }

        private void importarImagen()
        {
            try
            {
                if (opendialog.ShowDialog() == DialogResult.OK)
                {
                    string imagen = opendialog.FileName;
                    pb_producto.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private MemoryStream exportarImagen(object objeto)
        {
            byte[] imagen = (byte[])objeto;
            MemoryStream stream = new MemoryStream(imagen);
            return stream;
        }

        private void mostrarTablaProductos()
        {
            DataTable auxiliar = ConexionBD.obtenerRegistros();
            if (auxiliar.IsInitialized)
            {
                dataGridView_productos.DataSource = auxiliar;
            }
        }

        private void mostrarImagenesDefault()
        {
            string[] imagenes = obtenerImagenesDefault();

            while (estado)
            {
                for (int i = 0; i < imagenes.Length; i++)
                {
                    if(estado)
                    {
                        pb_producto.ImageLocation = imagenes[i];
                        Thread.Sleep(5000);
                    }
                }
            }
            
        }

        private string[] obtenerImagenesDefault()
        {
            string[] imagenes = new string[4];
               for(int i=0; i<imagenes.Length; i++)
            {
                imagenes[i] = "images/" + i + ".png";
            }
            return imagenes;
        }

        private byte[] pictureBoxToImagen(PictureBox pb)
        {
            MemoryStream stream = new MemoryStream();
            pb.Image.Save(stream, ImageFormat.Jpeg);
            byte[] imagen = stream.ToArray();
            return imagen;
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            llenarCategorias();
            dataGridView_productos.DataSource = ConexionBD.obtenerRegistros();
        }

        private void llenarCategorias()
        {
            ArrayList categorias = ConexionBD.ObtenerCategorias();
            if(categorias != null)
            {
                for (int i = 0; i < categorias.Count; i++)
                {
                    cb_categoria.Items.Add(categorias[i]);
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombreColumna = dataGridView_productos.Columns[e.ColumnIndex].HeaderText;
            if (nombreColumna.Equals("imagen"))
            {
                estado = false;
                object objeto = dataGridView_productos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                pb_producto.Image = Image.FromStream(exportarImagen(objeto));
            }
            if (nombreColumna.Equals("Vender"))
            {
                int cantidadVender = int.Parse(Interaction.InputBox("Cantidad de productos a comprar", "Venta de productos"));
                int cantidadInventario = int.Parse(dataGridView_productos.Rows[e.RowIndex].Cells[5].Value.ToString());
                if(cantidadVender > cantidadInventario)
                {
                    MessageBox.Show("No se pueden comprar mas productos de los que hay en el inventario");
                } else
                {
                    string idUsuarioVende = ConexionBD.getUsuario();
                    string idProducto = dataGridView_productos.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string descripcion = dataGridView_productos.Rows[e.RowIndex].Cells[3].Value.ToString();
                    double precio = Double.Parse(dataGridView_productos.Rows[e.RowIndex].Cells[4].Value.ToString());
                    ProductoVenta producto = new ProductoVenta(idUsuarioVende, idProducto, descripcion, cantidadInventario , cantidadVender, precio);
                    ListaVenta.AgregarProductoVenta(producto);
                }
            }
            if(nombreColumna.Equals("Seleccionar"))
            {
                tbox_id.Text = dataGridView_productos.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbox_descripcion.Text = dataGridView_productos.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbox_existencia.Text = dataGridView_productos.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbox_precio.Text = dataGridView_productos.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void dataGridView_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_ver_venta_Click(object sender, EventArgs e)
        {
            FormVenta form = new FormVenta();
            form.MaximizeBox = false;
            form.Show();
        }
    }
}
