using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtID.Text;
            string password = txtContraseña.Text;

            if (IsValidUser(username, password))
            {
               
                MessageBox.Show("Bienvenido al sistema", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Close();   

                MenuPrincipal menuPrincipal = new MenuPrincipal();

                menuPrincipal.ShowDialog();

            }
            else
            {
                // Las credenciales son inválidas, así que mostrar un mensaje de error
                MessageBox.Show("Nombre de usuario o contraseña inválidos", "Inicio de sesión fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidUser(string username, string password)
        {
            // Aquí debes verificar si las credenciales son válidas, por ejemplo:
            if (username == "admin" && password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
