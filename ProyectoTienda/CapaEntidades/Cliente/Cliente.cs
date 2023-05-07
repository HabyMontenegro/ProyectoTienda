using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente
    {

        public int Id;
        public string Cedula;
        public string Nombre;
        public string Apellido;

        

        public Cliente(int id, string cedula, string nombre, string apellido)
        {
            this.Id = id;
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

 
        public override string ToString()
        {
            return $"{Id}; {Cedula}; {Nombre}; {Apellido}";
        }
        
    }
}
