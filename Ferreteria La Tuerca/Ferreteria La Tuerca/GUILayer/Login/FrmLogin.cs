using System;
using System.Drawing;
using System.Windows.Forms;
using Ferreteria_La_Tuerca.BussinessLayer;
using Ferreteria_La_Tuerca.GUILayer.Principal;

namespace Ferreteria_La_Tuerca
{

    public partial class FrmLogin : Form
    {
        private readonly UserServices userService;
        public FrmLogin()
        {
            InitializeComponent();
            userService = new UserServices();
        }
        public void LimpiarCampos()
        {
            TxtUser.Text = "";
            TxtPassword.Text = "";
        }
        private void TxtUser_Enter(object sender, EventArgs e)
        {
            TxtUser.ForeColor = SystemColors.ControlText;
            TxtUser.Text = "";

        }
        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            TxtPassword.ForeColor = SystemColors.ControlText;
            TxtPassword.Text = "";
            TxtPassword.UseSystemPasswordChar = true;
        }
        private void TxtPassword_Leave(object sender, EventArgs e)
        {

            if (TxtPassword.Text.Equals(""))
            {
                TxtPassword.ForeColor = SystemColors.InactiveCaption;
                TxtPassword.Text = "Contraseña";
                TxtPassword.UseSystemPasswordChar = false;
            }
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {

                if (TxtUser.Text.Equals(""))
                {
                    TxtUser.ForeColor = SystemColors.InactiveCaption;
                    TxtUser.Text = "Usuario";
                }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs exit)
        {
            DialogResult response;
            response = MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.No)
                exit.Cancel = true;

            else
                Environment.Exit(0);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text.Equals("Usuario") || TxtPassword.Text.Equals("Contraseña") || TxtUser.Text.Equals("") || TxtPassword.Text.Equals(""))
            {
                MessageBox.Show("Ingrese los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtUser.Focus();


            }
            else
            {

                var usr = userService.ValidateUser(TxtUser.Text, TxtPassword.Text);
                if (usr != null)
                {
                    FrmLogin Form = this;
                    MessageBox.Show("Usuario Logeado!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmPrincipal principal = new FrmPrincipal(usr,Form);
                    principal.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Ingrese los Datos correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarCampos();
                    TxtUser.Focus();
                }



            }
        }
    }
}
