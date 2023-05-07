using CapaEntidades;
using CapaLogica.Implementaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using static System.Net.WebRequestMethods;
using System.Xml;

namespace CapaPresentacion.Interfaces_Cliente
{
    public partial class FormularioClientes : Form
    {
        int posicion;

        ServicioCliente servicioCliente = new ServicioCliente();



        #region CRUD

        public void crear()
        {

            int Id = int.Parse(txtID1.Text);
            string Cedula = txtCedula1.Text;
            string Nombre = txtNombre1.Text;
            string Apellido = txtApellido1.Text;

            servicioCliente.agregar(new Cliente(Id, Cedula, Nombre, Apellido));

            MessageBox.Show("Cliente Registrado");

        }
        public void leer()
        {
            string ruta = "Archivo_Cliente.txt";
            if (!System.IO.File.Exists(ruta))
            {

            }
            else
            {
                List<string> lines = new List<string>();
                StreamReader reader = new StreamReader(ruta);

                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }

                List<string[]> rows = new List<string[]>();
                foreach (string line in lines)
                {
                    string[] columns = line.Split(';');
                    rows.Add(columns);
                }


                foreach (string[] row in rows)
                {
                    DgvClientes.Rows.Add(row);
                }
                reader.Close();
            }
            
        }
        //public void CargarGrilla()
        //{
        //    foreach (var item in servicioCliente.GetClientes())
        //    {
        //        DgvClientes.Rows.Add(item.Id, item.Cedula, item.Nombre, item.Apellido);
        //    }
        //}
        public void eliminar()
        {
            string ruta = "Archivo_Cliente.txt";
          

            posicion = DgvClientes.CurrentRow.Index;

            DgvClientes.Rows.RemoveAt(posicion);

            

            StreamWriter sw = new StreamWriter(ruta);

            

            // Iterar a través de las filas y columnas del DataGridView
            for (int i = 0; i < DgvClientes.Rows.Count; i++)
            {
                for (int j = 0; j < DgvClientes.Columns.Count; j++)
                {
                    // Escribir cada valor de celda en el archivo de texto, separados por comas
                    sw.Write(DgvClientes.Rows[i].Cells[j].Value.ToString());

                    // Agregar una coma a menos que sea la última columna
                    if (j < DgvClientes.Columns.Count - 1)
                    {
                        sw.Write(";");
                    }
                }
                // Agregar un salto de línea al final de cada fila
                sw.WriteLine();
            }

            // Cerrar el archivo de texto
            sw.Close();

  

        }
        #endregion


        public FormularioClientes()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            crear();
        }

        private void FormularioClientes_Load(object sender, EventArgs e)
        {
            leer();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();

        }
    }
}
