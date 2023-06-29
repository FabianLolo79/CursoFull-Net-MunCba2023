using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeBanco.Cuentas
{
    internal abstract class CuentaBancaria
    {
        private long numeroCuenta;
        private double saldo;

        protected CuentaBancaria(long numeroCuenta, double saldo)
        {
            this.numeroCuenta=numeroCuenta;
            this.saldo=saldo;
        }

        public long NumeroCuenta { get => numeroCuenta; set => numeroCuenta=value; }
        public double Saldo { get => saldo; set => saldo=value; }

        public abstract void Extraer(double monto);
        /*{
            Console.WriteLine("Ejecutando Extraer de la Cuenta bancaria " + NumeroCuenta);
            Saldo = Saldo - monto;
        }*/
    }
}
