using CapaPresentacion.Interfaces_Cliente;
using CapaPresentacion.Interfaces_Inventario;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Close();

            FormularioClientes formularioClientes = new FormularioClientes();

            formularioClientes.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Close();

            FormularioDeInventario formularioDeInventario = new FormularioDeInventario();

            
            formularioDeInventario.ShowDialog();

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            this.Close();

            FormularioFacturar FF = new FormularioFacturar();

            FF.ShowDialog();
        }
    }
}
