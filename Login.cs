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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string usuario = tbox_usuario.Text;
            string contraseña = tbox_contraseña.Text;
            if(ConexionBD.ValidarUsuario(usuario, contraseña))
            {
                this.Hide();
                //Inventario form = new Inventario();
                //form.MaximizeBox = false;
                //form.Show();
                Cargando load = new Cargando();
                load.MaximizeBox = false;
                load.Show();
            } 
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro form = new Registro();
            form.MaximizeBox = false;
            form.Show();
        }
    }
}
