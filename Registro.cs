using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Conexion_BD
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            string usuario = tbox_rusuario.Text;
            string contraseña = tbox_rcontraseña.Text;
            if (ConexionBD.RegistrarUsuario(usuario, contraseña))
            {
                this.Dispose();
                Login form = new Login();
                form.MaximizeBox = false;
                form.Show();
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login form = new Login();
            form.MaximizeBox = false;
            form.Show();
        }
    }
}
