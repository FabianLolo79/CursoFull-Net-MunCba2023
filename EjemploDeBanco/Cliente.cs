using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeBanco
{
    internal class Cliente
    {
        private long numeroDeCliente;
        private string nombre;
        private string apellido;

        public Cliente(long numeroDeCliente)
        {
            this.numeroDeCliente=numeroDeCliente;
        }

        public Cliente(long numeroDeCliente, string nombre)
        {
            this.numeroDeCliente=numeroDeCliente;
            this.nombre=nombre;
        }
        public Cliente(long numeroDeCliente, string nombre, string apellido)
        {
            this.numeroDeCliente=numeroDeCliente;
            this.nombre=nombre;
            this.apellido=apellido;
        }

        public Cliente()
        {
        }

        public override string ToString()
        {
            return "[Cliente] " + this.numeroDeCliente + " " + this.nombre + " " + this.apellido;
        }

        public long NumeroDeCliente { get => numeroDeCliente; set => numeroDeCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido=value; }
    }
}
