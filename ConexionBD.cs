using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Conexion_BD
{
    static class ConexionBD
    {
        private static string contraseña = "JSevenfoldStadia@16";
        private static string servidor = "localhost";
        private static string puerto = "3306";
        private static string usuario = "root";
        private static string urlConexion = "server=" + servidor + "; port=" + puerto +
                "; user id=" + usuario + "; password=" + contraseña + "; database=mysql;";
        private static MySqlConnection conexion = new MySqlConnection(urlConexion);
        private static string idUsuario;

        private static void AbrirConexion()
        {
            if(conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

        }

        private static void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public static Boolean RegistrarUsuario(string nombreUsuario, string contraseña)
        {
            try
            {
                AbrirConexion();
                string query = "insert into proyecto_topicos.usuarios(nombre_usuario, contraseña) " +
                    "values('" + nombreUsuario + "','" + contraseña + "');";
                MySqlCommand usuario = new MySqlCommand(query, conexion);
                usuario.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado correctamente");
                CerrarConexion();
                return true;
            } catch(MySqlException e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

        }

        public static Boolean ValidarUsuario(string nombreUsuario, string contraseña)
        {
            try
            {
                AbrirConexion();
                string query = "SELECT * FROM proyecto_topicos.usuarios where nombre_usuario ='" + nombreUsuario 
                    + "' AND contraseña = '" + contraseña + "';";
                string datos = "";
                MySqlCommand cmd = new MySqlCommand(query , conexion);
                MySqlDataReader lector = null;
                lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    datos = lector["nombre_usuario"] + " " + lector["contraseña"];
                }
                if(datos.Contains(nombreUsuario) && datos.Contains(contraseña))
                {
                    idUsuario = lector["id_usuario"].ToString();
                    conexion.Close();
                    return true;
                }
                conexion.Close();
                return false;
            }
            catch (MySqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
                return false;
            }
        }

        public static string getUsuario()
        {
            return idUsuario;
        }

        public static ArrayList ObtenerCategorias()
        {
            ArrayList categorias = new ArrayList();

            try
            {
                AbrirConexion();
                string query = "SELECT nombre FROM proyecto_topicos.categorias";
                MySqlCommand command = new MySqlCommand(query, conexion);
                MySqlDataReader lector = command.ExecuteReader();
                while (lector.Read())
                {
                    categorias.Add(lector["nombre"].ToString());
                }
                CerrarConexion();
                return categorias;
            } catch(MySqlException e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }

        }

        public static void RegistrarProducto(string descripcion, string precio, string existencias, string categoria, byte[] imagen)
        {
            try
            {
                AbrirConexion();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexion;
                command.CommandText = "INSERT INTO proyecto_topicos.productos(descripcion, precio, numero_existencia, id_categoria, imagen) VALUES(@descripcion, @precio, @existencia, (SELECT id_categoria FROM proyecto_topicos.categorias WHERE nombre = @categoria), @imagen)";
                command.Parameters.AddWithValue("@descripcion", descripcion);
                command.Parameters.AddWithValue("@precio", precio);
                command.Parameters.AddWithValue("@existencia", existencias);
                command.Parameters.AddWithValue("@categoria", categoria);
                command.Parameters.AddWithValue("@imagen", imagen);
                command.ExecuteNonQuery();
                MessageBox.Show("Producto registrado correctamente");
                CerrarConexion();
            } catch(MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public static void ActualizarProducto(string id,  string descripcion, string precio, 
                                              string existencias, string categoria, byte[] imagen)
        {
            try
            {
                AbrirConexion();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexion;
                command.CommandText = "UPDATE proyecto_topicos.productos SET descripcion = @descripcion, precio = @precio, numero_existencia = @existencia, id_categoria = (SELECT id_categoria FROM proyecto_topicos.categorias WHERE nombre = @categoria), imagen = @imagen WHERE id_producto = @id";
                command.Parameters.AddWithValue("@descripcion", descripcion);
                command.Parameters.AddWithValue("@precio", precio);
                command.Parameters.AddWithValue("@existencia", existencias);
                command.Parameters.AddWithValue("@categoria", categoria);
                command.Parameters.AddWithValue("@imagen", imagen);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Producto Actualizado");
                CerrarConexion();
            } 
            catch(MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public static void EliminarProducto(string id)
        {
            try
            {
                AbrirConexion();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexion;
                command.CommandText = "DELETE FROM proyecto_topicos.productos WHERE id_producto = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Producto Eliminado");
                CerrarConexion();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public static DataTable obtenerRegistros()
        {
            try
            {
                string query = "SELECT id_producto, descripcion, precio, numero_existencia, categorias.nombre AS nombre_categoria, imagen FROM proyecto_topicos.productos JOIN proyecto_topicos.categorias ON productos.id_categoria = categorias.id_categoria";
                MySqlCommand command = new MySqlCommand(query, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = command;
                DataTable dtable = new DataTable();
                adaptador.Fill(dtable);
                return dtable;
            }
            catch (MySqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
                return null;
            }
        }

        public static void RegistrarListaVentas(List<ProductoVenta> ventas)
        {
            for (int i = 0; i < ventas.Count; i++)
            {
                if(ConexionBD.RegistrarVenta(ventas[i]))
                {
                    ConexionBD.ActualizarExistencia(ventas[i].id_producto, ventas[i].cantidad_inventario, ventas[i].cantidad_vender);
                    ListaVenta.LimpiarListaVentas();
                }
                
            }
            MessageBox.Show("Ventas registradas correctamente");
        }

        public static Boolean RegistrarVenta(ProductoVenta producto)
        {
            try
            {
                AbrirConexion();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexion;
                command.CommandText = "INSERT INTO proyecto_topicos.ventas(id_usuario_vende, id_producto, cantidad, precio_unitario, precio_total) VALUES(@idUsuarioVende, @idProducto, @cantidad, @precioUnitario, @precioTotal)";
                command.Parameters.AddWithValue("@idUsuarioVende", producto.id_usuario_vende);
                command.Parameters.AddWithValue("@idProducto", producto.id_producto);
                command.Parameters.AddWithValue("@cantidad", producto.cantidad_vender);
                command.Parameters.AddWithValue("@precioUnitario", producto.precio_unitario);
                command.Parameters.AddWithValue("@precioTotal", producto.precio_total);
                command.ExecuteNonQuery();
                CerrarConexion();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public static void ActualizarExistencia(string idProducto, int cantidadInventario, int cantidadVender)
        {
            int nuevaExistencia = cantidadInventario - cantidadVender;
            try
            {
                AbrirConexion();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexion;
                command.CommandText = "UPDATE proyecto_topicos.productos SET numero_existencia = @existencia WHERE id_producto = @idProducto";
                command.Parameters.AddWithValue("@existencia", nuevaExistencia);
                command.Parameters.AddWithValue("@idProducto", idProducto);
                command.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public static DataTable ObtenerVentas()
        {
            try
            {
                string query = "SELECT id_venta, id_usuario_vende, usuarios.nombre_usuario AS usuario_vende, ventas.id_producto, productos.descripcion, cantidad, precio_unitario, precio_total FROM proyecto_topicos.ventas JOIN proyecto_topicos.usuarios ON ventas.id_usuario_vende = usuarios.id_usuario JOIN proyecto_topicos.productos ON ventas.id_producto = productos.id_producto";
                MySqlCommand command = new MySqlCommand(query, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = command;
                DataTable dtable = new DataTable();
                adaptador.Fill(dtable);
                return dtable;
            }
            catch (MySqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
                return null;
            }
        }

    }
}
