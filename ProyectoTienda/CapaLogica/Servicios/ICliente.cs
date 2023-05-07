using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaLogica.Servicios
{
    public interface ICliente
    {
      //  List<Cliente> GetClientes();
        string agregar(Cliente cliente);
    }
}
