using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.Entities;
using Ferreteria.BusinesLogic;

namespace Ferreteria
{
    public partial class CargaSistema : Form
    {
        public CargaSistema(string usuario, string password)
        {
            InitializeComponent();
            CargarDatosUsuario(usuario, password);
        }

        private void CargarDatosUsuario(string usuario, string password)
        {
            BusinesLogic.AB_Varios.CargarPerfil(usuario, password);
            BusinesLogic.AB_Varios.CargarEmpleado(usuario, password);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            barraCarga.Value += 1;
            if (barraCarga.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
                Principal ventana = new Principal();
                ventana.Show();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = User.NameUser;
            this.Opacity = 0.0;
            timer1.Start();
        }
    }
}
