using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        List<Arriendo> Lista = new List<Arriendo>();
        Sucursal sucursal1 = new Sucursal("sucursal1", "lolol 123", 007);
        static void Main(string[] args)
        {
            Console.WriteLine("hola, desea arrendar un vehículo?");
            var a = Console.ReadLine();
            if (a == "si")
            {
                Arriendo arriendo = new Arriendo();
                Console.WriteLine("Es usted persona, empresa, organizacion o institucion");
                var b = Console.ReadLine();
                if (b == "persona")
                {
                    Console.WriteLine("ingrese su nombre:");
                    var name = Console.ReadLine();
                    Console.WriteLine("ingrese su rut");
                    var RT = Console.ReadLine();
                    Console.WriteLine("ingrese su telefono:");
                    var tel = Console.ReadLine();
                    Console.WriteLine("ingrese su email");
                    var Mail = Console.ReadLine();
                    Console.WriteLine("ingrese su Edad");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese su Clase Licencia:");
                    var CL = Console.ReadLine();
                    Console.WriteLine("ingrese su sexo");
                    var Sx = Console.ReadLine();
                    Persona persona = new Persona(RT, name, tel, Mail, age, CL, Sx);
                    arriendo.cliente = persona;
                }
                if (b == "Empresa")
                {
                    Console.WriteLine("ingrese su nombre:");
                    var name = Console.ReadLine();
                    Console.WriteLine("ingrese su rut");
                    var RT = Console.ReadLine();
                    Console.WriteLine("ingrese su telefono:");
                    var tel = Console.ReadLine();
                    Console.WriteLine("ingrese su email");
                    var Mail = Console.ReadLine();
                    Console.WriteLine("ingrese su rubro");
                    var Rub = Console.ReadLine();
                    Console.WriteLine("ingrese su autorización:");
                    var CL = Console.ReadLine();

                    Empresa empresa = new Empresa(RT, name, tel, Mail, Rub, CL);
                    arriendo.cliente = empresa;
                }
                if (b == "Organizacion")
                {
                    Console.WriteLine("ingrese su nombre:");
                    var name = Console.ReadLine();
                    Console.WriteLine("ingrese su rut");
                    var RT = Console.ReadLine();
                    Console.WriteLine("ingrese su telefono:");
                    var tel = Console.ReadLine();
                    Console.WriteLine("ingrese su email");
                    var Mail = Console.ReadLine();
                    Console.WriteLine("ingrese su rubro");
                    var Rub = Console.ReadLine();
                    Console.WriteLine("ingrese su autorización:");
                    var CL = Console.ReadLine();

                    Organizacion organizacion = new Organizacion(RT, name, tel, Mail, Rub, CL);
                    arriendo.cliente = organizacion;

                }
                if (b == "Institución")
                {
                    Console.WriteLine("ingrese su nombre:");
                    var name = Console.ReadLine();
                    Console.WriteLine("ingrese su rut");
                    var RT = Console.ReadLine();
                    Console.WriteLine("ingrese su telefono:");
                    var tel = Console.ReadLine();
                    Console.WriteLine("ingrese su email");
                    var Mail = Console.ReadLine();
                    Console.WriteLine("ingrese su rubro");
                    var Rub = Console.ReadLine();
                    Console.WriteLine("ingrese su autorización:");
                    var CL = Console.ReadLine();

                    Institucion institucion = new Institucion(RT, name, tel, Mail, Rub, CL);
                    arriendo.cliente = institucion;

                }
                Console.WriteLine("en que sucursal desea arrendar su vehículo");
                var c = Console.ReadLine();
                if (c == "sucursal1")
                {
                    //arriendo.sucursal = sucursal1
                    //ver porque esto no funciona, crear sucursales, vehículos y accesorios, y establecer un contador de vehículos
                    // a parte de una relación entre vehículos y sucursales que permita tener un numero de ciertos vehiculos en las sucursales
                    // y actualizar este numero ha medida que se van realizando arriendos.

                }

            }
        }

    }
}

