using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Cliente
    {
        string Rut, Nombre, TelefonoContacto, Email;
        public Cliente(string rut, string nombre, string telefono, string email)
        {
            this.Rut = rut;
            this.Nombre = nombre;
            this.TelefonoContacto = telefono;
            this.Email = email;
            
        }

    }
    public class Persona :Cliente
    {
        int Edad;
        string ClaseLicencia, Sexo;
        
        public Persona(string rut, string nombre, string telefono, string email, int edad, string claselicencia, string sexo)
            : base(rut,nombre,telefono,email)
        {
            this.Edad = edad;
            this.ClaseLicencia = claselicencia;
            this.Sexo = sexo;          


        }
        
    }
    public class Empresa : Cliente
    {
        string Rubro;
        string Autorizacion;

        public Empresa(string rut, string nombre, string telefono, string email,string rubro, string autorización)
            : base(rut, nombre, telefono, email)
        {
            this.Rubro = rubro;
            this.Autorizacion = autorización;

        }
        
    }

    public class Organizacion : Cliente
    {
        string Rubro;
        string Autorizacion;

        public Organizacion(string rut, string nombre, string telefono, string email, string rubro, string autorización)
            : base(rut, nombre, telefono, email)
        {
            this.Rubro = rubro;
            this.Autorizacion = autorización;

        }
       
    }
    public class Institucion : Cliente
    {
        string Rubro;
        string Autorizacion;

        public Institucion(string rut, string nombre, string telefono, string email, string rubro, string autorización)
            : base(rut, nombre, telefono, email)
        {
            this.Rubro = rubro;
            this.Autorizacion = autorización;

        }
       
    }
}
