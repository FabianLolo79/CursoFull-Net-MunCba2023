using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeBanco.Cuentas
{
    
    internal class CuentaCorriente : CuentaBancaria
    {
        private double limiteExtra = 10000;

        public CuentaCorriente(long numeroCuenta, double saldo, double limiteExtra) : base(numeroCuenta, saldo)
        {
        }

        public double LimiteExtra { get => limiteExtra; set => limiteExtra=value; }

        public override void Extraer(double monto)
        {
            if ((base.Saldo + LimiteExtra) - monto >= 0)
            {
                base.Saldo = base.Saldo - monto;
            }
            else
            {
                Console.WriteLine("Me suena que no tenés viyuya suficiente!!!!... JA JA JA.");
            }
        }
    }
}
