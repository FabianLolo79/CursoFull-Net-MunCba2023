using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEjemploADONET
{
    internal class Articulo
    {
        private int IdArticulo;
        private string nombre;
        private double precio;

        public Articulo()
        {
        }

        public Articulo(int idArticulo, string nombre, double precio)
        {
            this.IdArticulo=idArticulo;
            this.Nombre=nombre;
            this.Precio=precio;
        }

        public int IdArticulo1 { get => IdArticulo; set => IdArticulo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio=value; }
    }
}
