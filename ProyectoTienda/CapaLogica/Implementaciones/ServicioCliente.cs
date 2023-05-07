using CapaDatos;
using CapaEntidades;
using CapaLogica.Servicios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Implementaciones
{
    public class ServicioCliente : ICliente
    {
        
        ArchivoCliente archivoCliente = new ArchivoCliente();

        List<Cliente> clientes = null;

        public ServicioCliente()
        {
            clientes = new List<Cliente>();
        }
        
        public string agregar(Cliente clientes)
        {
            if (clientes == null) return "No se ha enviado informaciòn";

            archivoCliente.guardar(clientes);


            return "Cliente guardado con exito";
        }

        //public List<Cliente> GetClientes()
        //{
        //    List<string> lines = new List<string>();
        //    string ruta = "Archivo_Cliente.txt";
        //    StreamReader sr = new StreamReader(ruta);

        //    {
        //        string line;
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            lines.Add(line);
        //        }
        //    }

        //    return lines;
        //}
    }
}
