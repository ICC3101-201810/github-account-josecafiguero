using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sucursal
    {
        string NombreSucursal, Direccion;
        int Telefono;
        public Sucursal(string nombre, string direccion,int telefono)
        {
            this.NombreSucursal = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }
    }
}
