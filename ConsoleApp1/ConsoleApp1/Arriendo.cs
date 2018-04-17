using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Arriendo
    {
        public Cliente cliente { get; set; }
        public Vehiculo vehiculo { get; set; }
        public Sucursal sucursal { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino  { get; set; }


    }
    
}
