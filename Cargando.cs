using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Conexion_BD
{
    public partial class Cargando : Form
    {
        public Cargando()
        {
            InitializeComponent();
        }

        private async void Cargando_Load(object sender, EventArgs e)
        {
            Task tarea = new Task(cargar);
            tarea.Start();
            await tarea;
            if(tarea.IsCompleted)
            {
                this.Hide();
                Inventario form = new Inventario();
                form.MaximizeBox = false;
                form.Show();
            }
        }
        private void cargar()
        {
            Thread.Sleep(3000);
        }
    }
}
