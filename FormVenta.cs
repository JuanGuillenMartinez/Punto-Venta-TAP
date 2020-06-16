using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Conexion_BD.Resources
{
    public partial class FormVenta : Form
    {
        public FormVenta()
        {
            InitializeComponent();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            gridVentas.DataSource = ListaVenta.ObtenerProductosVenta();
            grid_registro_ventas.DataSource = ConexionBD.ObtenerVentas();
        }

        private void btnRegistrarVentas_Click(object sender, EventArgs e)
        {
            ConexionBD.RegistrarListaVentas(ListaVenta.ObtenerProductosVenta());
        }

        private void btn_actualizar_ventas_Click(object sender, EventArgs e)
        {
            grid_registro_ventas.DataSource = ConexionBD.ObtenerVentas();
        }

        private void btn_cancelar_venta_Click(object sender, EventArgs e)
        {
            ListaVenta.LimpiarListaVentas();
        }
    }
}
