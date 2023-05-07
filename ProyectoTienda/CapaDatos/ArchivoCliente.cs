using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class ArchivoCliente
    {
        string ruta = "Archivo_Cliente.txt";

        public string guardar(Cliente cliente)
        {
            StreamWriter sw = new StreamWriter(ruta, true);

            sw.WriteLine(cliente.ToString());
            sw.Close();

            return "Cliente Nuevo Registrado Con Exito";
        }
    }
}
