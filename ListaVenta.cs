using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Conexion_BD
{
    static class ListaVenta
    {
        private static List<ProductoVenta> ventas = new List<ProductoVenta>();

        public static void AgregarProductoVenta(ProductoVenta producto)
        {
            ventas.Add(producto);
        }

        public static List<ProductoVenta> ObtenerProductosVenta()
        {
            return ventas;
        }

        public static void LimpiarListaVentas()
        {
            ventas = null;
            ventas = new List<ProductoVenta>();
        }

    }
}
