using EjemploDeBanco.Cuentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeBanco
{
    internal class Banco
    {

        public void ExtraeDineroDeCuentaBancaria(CuentaBancaria cuenta, double monto)
        {
            Type tipoDeClase = cuenta.GetType();
            Console.WriteLine(tipoDeClase.Name);
            cuenta.Extraer(monto); //POLIMORFISMO!!!!
        }

        public void ExtraeDineroDeCuentaBancaria(CuentaBancaria cuenta, double monto, double impuesto)
        {
            this.ExtraeDineroDeCuentaBancaria(cuenta, monto + impuesto);
            /*Type tipoDeClase = cuenta.GetType();
            Console.WriteLine(tipoDeClase.Name);
            cuenta.Extraer(monto);*/ //POLIMORFISMO!!!!
        }

    }
}
