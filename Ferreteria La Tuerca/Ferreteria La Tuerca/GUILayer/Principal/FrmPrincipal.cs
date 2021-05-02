using System;
using System.Windows.Forms;
using Ferreteria_La_Tuerca.Entities;
using Ferreteria_La_Tuerca.BussinessLayer;

namespace Ferreteria_La_Tuerca.GUILayer.Principal
{
    public partial class FrmPrincipal : Form
    {
        private User user;
        private FrmLogin form;
        public FrmPrincipal(User user,FrmLogin form)
        {
            InitializeComponent();
            this.user = user;
            this.form = form;
            ValidateUserPerfil();
            LblUserName.Text = "Usuario: " + user.nameUser;
        }
        private void ValidateUserPerfil()
        {
            if (user.Perfil == 2)
            {
                
            }
        }
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs exit)
        {
            DialogResult response;
            response = MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.No)
                exit.Cancel = true;

            else
                Environment.Exit(0);
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs exit)
        {
            DialogResult response;
            response = MessageBox.Show("Seguro que desea cerrar sesion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                this.Hide();
                this.form.Show();
            }


        }
    }
}
