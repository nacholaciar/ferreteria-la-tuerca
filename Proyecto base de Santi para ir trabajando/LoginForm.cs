using Ferreteria.AccesoADatos;
using Ferreteria.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text.Equals("") && txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre de usuario y password");
            }
            else
            {
                string nombreDeUsuario = txtUsuario.Text;
                string password = txtPassword.Text;
                BusinesLogic.AB_Varios.CargarLogin(nombreDeUsuario, password);
                this.Hide();
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
