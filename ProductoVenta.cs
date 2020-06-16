using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Conexion_BD
{
    class ProductoVenta
    {
        public string id_usuario_vende { get; set; }
        public string id_producto { get; set; }
        public string descripcion { get; set; }
        public int cantidad_inventario { get; set; }
        public int cantidad_vender { get; set; }
        public double precio_unitario { get; set; }
        public double precio_total { get; set; }

        public ProductoVenta(string idUsuarioVende, string idProducto, string nombreProducto, int cantidadInventario, int cantidadVender, double precio)
        {
            this.id_usuario_vende = idUsuarioVende;
            this.id_producto = idProducto;
            this.descripcion = nombreProducto;
            this.cantidad_inventario = cantidadInventario;
            this.cantidad_vender = cantidadVender;
            this.precio_unitario = precio;
            this.precio_total = cantidadVender * precio;
        }
    }
}
