using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Vehiculo
    {
        public string Patente, Color, Tipo;
        public Vehiculo(string Patente, string Color, string Tipo)
        {
            this.Patente = Patente;
            this.Color = Color;
            this.Tipo = Tipo;

        }

    }

    public class Auto : Vehiculo
    {
        public string Marca, Modelo;
        public int Año;
        public Accesorios GetAccesorios { get; set; }
        public Auto(string Patente, string Color, string Tipo, string Marca, string Modelo, int Año)
            : base(Patente, Color, Tipo)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Año = Año;
        }
        

    }
    public class Acuatico : Vehiculo
    {
        public Accesorios GetAccesorios { get; set; }
        public string Marca, Modelo;
        public int Año;
        public Acuatico(string Patente, string Color, string Tipo, string Marca, string Modelo, int Año)
            : base(Patente, Color, Tipo)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Año = Año;
        }

    }
    public class Moto : Vehiculo
    {
        public Accesorios GetAccesorios { get; set; }
        public string Marca, Modelo;
        public int Año;
        public Moto(string Patente, string Color, string Tipo, string Marca, string Modelo, int Año)
            : base(Patente, Color, Tipo)
        {   
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Año = Año;
        }

    }
    public class Camion : Vehiculo
    {
        public Accesorios GetAccesorios { get; set; }
        public string Marca, Modelo;
        public int Año;
        public Camion(string Patente, string Color, string Tipo,string Marca, string Modelo, int Año)
            : base(Patente, Color, Tipo)
        {
            
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Año = Año;
        }

    }
    public class Bus : Vehiculo
    {
        public Accesorios GetAccesorios { get; set; }
        public string Marca, Modelo;
        public int Año;
        public Bus(string Patente, string Color, string Tipo,string Marca, string Modelo, int Año)
            : base(Patente, Color, Tipo)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Año = Año;
        }

    }
    public class MaquinariaPesada : Vehiculo
    {
        public Accesorios GetAccesorios { get; set; }
        public string Marca, Modelo, Maquina;
        public int Año;
        public MaquinariaPesada(string Patente, string Color, string Tipo, string Marca, string Modelo,string Maquina, int Año)
             : base(Patente, Color, Tipo)
        {
            this.Maquina = Maquina;
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Año = Año;

        }

    }
}   
